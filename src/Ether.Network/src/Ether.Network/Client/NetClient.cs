using Ether.Network.Common;
using Ether.Network.Common.Data;
using Ether.Network.Packets;
using Ether.Network.Utils;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Ether.Network.Client
{
    /// <summary>
    /// Managed TCP client.
    /// </summary>
    public abstract class NetClient : NetUser, INetClient
    {
        private static readonly IPacketProcessor DefaultPacketProcessor = new NetPacketProcessor();

        private readonly IPEndPoint _ipEndPoint;
        private readonly SocketAsyncEventArgs _socketReceiveArgs;
        private readonly SocketAsyncEventArgs _socketSendArgs;
        private readonly AutoResetEvent _autoConnectEvent;
        private readonly AutoResetEvent _autoSendEvent;
        private readonly BlockingCollection<byte[]> _sendingQueue;
        private readonly BlockingCollection<byte[]> _receivingQueue;
        private readonly Task _sendingQueueWorker;
        private readonly Task _receivingQueueWorker;
        private readonly CancellationTokenSource _cancelTokenSource;
        private readonly CancellationToken _cancelToken;

        private bool _isDisposed;

        /// <summary>
        /// Gets the packet processor.
        /// </summary>
        protected virtual IPacketProcessor PacketProcessor => DefaultPacketProcessor;

        /// <summary>
        /// Gets the <see cref="NetClient"/> connected state.
        /// </summary>
        public bool IsConnected => this.Socket != null && this.Socket.Connected;

        /// <summary>
        /// Creates a new <see cref="NetClient"/> instance.
        /// </summary>
        /// <param name="host">Remote host or ip</param>
        /// <param name="port">Remote port</param>
        /// <param name="bufferSize">Buffer size</param>
        protected NetClient(string host, int port, int bufferSize)
        {
            this.Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this._ipEndPoint = NetUtils.CreateIpEndPoint(host, port);
            this._socketSendArgs = NetUtils.CreateSocketAsync(this.Socket, -1, this.IO_Completed);
            this._socketReceiveArgs = NetUtils.CreateSocketAsync(this, bufferSize, this.IO_Completed);
            this._autoConnectEvent = new AutoResetEvent(false);
            this._autoSendEvent = new AutoResetEvent(false);
            this._sendingQueue = new BlockingCollection<byte[]>();
            this._receivingQueue = new BlockingCollection<byte[]>();
            this._cancelTokenSource = new CancellationTokenSource();
            this._cancelToken = this._cancelTokenSource.Token;
            this._sendingQueueWorker = new Task(this.ProcessSendingQueue, this._cancelToken);
            this._receivingQueueWorker = new Task(this.ProcessReceiveQueue, this._cancelToken);
        }

        /// <inheritdoc />
        public void Connect()
        {
            if (this.IsConnected)
                throw new InvalidOperationException("Client is already connected to remote.");

            var connectSocket = NetUtils.CreateSocketAsync(this.Socket, -1, this.IO_Completed);
            connectSocket.RemoteEndPoint = this._ipEndPoint;

            if (this.Socket.ConnectAsync(connectSocket))
                this._autoConnectEvent.WaitOne();

            SocketError errorCode = connectSocket.SocketError;

            if (errorCode != SocketError.Success)
                throw new SocketException((int) errorCode);

            this._sendingQueueWorker.Start();
            this._receivingQueueWorker.Start();
            this.Token.Socket = this.Socket;
            this.Token.MessageHandler = data => this._receivingQueue.Add(data);

            if (!this.Socket.ReceiveAsync(this._socketReceiveArgs))
                this.ProcessReceive(this._socketReceiveArgs);
        }

        /// <inheritdoc />
        public void Disconnect()
        {
            if (this.IsConnected)
            {
#if !NETSTANDARD1_3
                this.Socket.Close();
#else
                this.Socket.Shutdown(SocketShutdown.Both);
                this.Socket.Dispose();
#endif
            }

            this._cancelTokenSource.Cancel(false);
            this.OnDisconnected();
        }

        /// <inheritdoc />
        public override void Send(INetPacketStream packet)
        {
            if (!this.IsConnected)
                throw new SocketException();

            this._sendingQueue.Add(packet.Buffer);
        }

        /// <summary>
        /// Triggered when the <see cref="NetClient"/> receives a packet.
        /// </summary>
        /// <param name="packet"></param>
        public override void HandleMessage(INetPacketStream packet)
        {
            // Nothing to handle
        }

        /// <summary>
        /// Triggered when the client is connected to the remote end point.
        /// </summary>
        protected abstract void OnConnected();

        /// <summary>
        /// Triggered when the client is disconnected from the remote end point.
        /// </summary>
        protected abstract void OnDisconnected();

        /// <summary>
        /// Triggered when a error on the socket happend
        /// </summary>
        /// <param name="socketError"></param>
        protected abstract void OnSocketError(SocketError socketError);

        /// <summary>
        /// Sends the packets in the sending queue.
        /// </summary>
        private void ProcessSendingQueue()
        {
            while (true)
            {
                try
                {
                    byte[] packetBuffer = this._sendingQueue.Take(this._cancelToken);

                    if (packetBuffer == null || packetBuffer.Length <= 0)
                        continue;

                    this._socketSendArgs.SetBuffer(packetBuffer, 0, packetBuffer.Length);

                    if (this.Socket.SendAsync(this._socketSendArgs))
                        this._autoSendEvent.WaitOne();
                }
                catch (Exception e)
                {
                    if ((e is AggregateException || e is OperationCanceledException) && this._cancelTokenSource.IsCancellationRequested)
                        break;
                }
            }
        }

        /// <summary>
        /// Process and dispatch the received packets.
        /// </summary>
        private void ProcessReceiveQueue()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = this._receivingQueue.Take(this._cancelToken);

                    if (buffer == null)
                        continue;

                    byte[] packetData = this.PacketProcessor.IncludeHeader
                        ? this.Token.HeaderData.Concat(buffer).ToArray()
                        : buffer;
                    this.Token.HeaderData = null;

                    Task.Run(() =>
                    {
                        using (INetPacketStream packet = this.PacketProcessor.CreatePacket(packetData))
                            this.HandleMessage(packet);
                    });
                }
                catch (Exception e)
                {
                    if ((e is AggregateException || e is OperationCanceledException) && this._cancelTokenSource.IsCancellationRequested)
                        break;
                }
            }
        }

        /// <summary>
        /// Process receieve.
        /// </summary>
        /// <param name="e"></param>
        private void ProcessReceive(SocketAsyncEventArgs e)
        {
            if (e.SocketError == SocketError.Success)
            {
                if (e.BytesTransferred <= 0 || !(e.UserToken is NetUser user))
                    return;

                IAsyncUserToken token = user.Token;

                token.TotalReceivedDataSize = token.NextReceiveOffset - token.DataStartOffset + e.BytesTransferred;
                SocketAsyncUtils.ProcessReceivedData(e, token, this.PacketProcessor, 0);
                SocketAsyncUtils.ProcessNextReceive(e, token);

                if (!user.Socket.ReceiveAsync(e))
                    this.ProcessReceive(e);
            }
            else if (e.SocketError == SocketError.ConnectionReset)
            {
                this.Disconnect();
            }
        }

        /// <summary>
        /// Triggered when a <see cref="SocketAsyncEventArgs"/> async operation is completed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IO_Completed(object sender, SocketAsyncEventArgs e)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender));

            if (e.SocketError == SocketError.ConnectionReset)
            {
                this.Disconnect();
                return;
            }

            if (e.SocketError != SocketError.Success)
                return;

            switch (e.LastOperation)
            {
                case SocketAsyncOperation.Connect:
                    this.OnConnected();
                    this._autoConnectEvent.Set();
                    break;
                case SocketAsyncOperation.Receive:
                    this.ProcessReceive(e);
                    break;
                case SocketAsyncOperation.Send:
                    this._autoSendEvent.Set();
                    break;
                case SocketAsyncOperation.Disconnect:
                    this.Disconnect();
                    break;
                default: throw new InvalidOperationException("Unexpected socket async operation.");
            }
        }

        /// <summary>
        /// Dispose the <see cref="NetClient"/> instance.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (!this._isDisposed)
            {
                this._autoConnectEvent.Dispose();
                this._autoSendEvent.Dispose();
                this.Disconnect();
            }

            this._isDisposed = true;

            base.Dispose(disposing);
        }
    }
}