using Ether.Network.Common.Data;
using Ether.Network.Packets;
using System;
using System.Linq;
using System.Net.Sockets;

namespace Ether.Network.Utils
{
    internal static class SocketAsyncUtils
    {
        public static void ProcessReceivedData(SocketAsyncEventArgs e, IAsyncUserToken token, IPacketProcessor packetProcessor, int alreadyProcessedDataSize)
        {
            while (true)
            {
                if (e == null)
                    throw new ArgumentNullException(nameof(e));
                
                if (alreadyProcessedDataSize >= token.TotalReceivedDataSize)
                    return;

                int dataStartOffset = token.DataStartOffset;
                int headerSize = packetProcessor.HeaderSize;

                if (!token.MessageSize.HasValue)
                {
                    if (token.TotalReceivedDataSize > headerSize && token.HeaderData == null)
                    {
                        token.HeaderData = NetUtils.GetPacketBuffer(e.Buffer, dataStartOffset, headerSize);
                        token.DataStartOffset = dataStartOffset + headerSize;
                        token.ReceivedHeaderBytesCount = headerSize;
                        alreadyProcessedDataSize += headerSize;
                    }
                    else if (token.ReceivedHeaderBytesCount < headerSize)
                    {
                        int rest = Math.Min(e.Buffer.Length - dataStartOffset, headerSize - token.ReceivedHeaderBytesCount);
                        byte[] remainingBuffer = NetUtils.GetPacketBuffer(e.Buffer, dataStartOffset, rest);

                        token.HeaderData = token.HeaderData?.Concat(remainingBuffer).ToArray() ?? remainingBuffer;

                        token.ReceivedHeaderBytesCount += remainingBuffer.Length;
                        token.DataStartOffset += remainingBuffer.Length;
                        alreadyProcessedDataSize += rest;
                    }
                }

                if (token.ReceivedHeaderBytesCount == headerSize)
                {
                    int messageSize = packetProcessor.GetLength(token.HeaderData);

                    token.MessageSize = messageSize - headerSize;
                    token.ReceivedHeaderBytesCount = 0;
                }

                if (token.MessageSize.HasValue)
                {
                    int messageSize = token.MessageSize.Value;
                    dataStartOffset = token.DataStartOffset;

                    if (token.TotalReceivedDataSize - alreadyProcessedDataSize >= messageSize && token.MessageData == null)
                    {
                        token.MessageData = NetUtils.GetPacketBuffer(e.Buffer, dataStartOffset, messageSize);
                        token.DataStartOffset = dataStartOffset + messageSize;
                        token.MessageSize = null;
                        token.ReceivedMessageBytesCount = messageSize;
                        alreadyProcessedDataSize += messageSize;
                    }
                    else if (token.ReceivedMessageBytesCount < messageSize)
                    {
                        int rest = Math.Min(e.Buffer.Length - dataStartOffset, messageSize - token.ReceivedMessageBytesCount);
                        byte[] remainingBuffer = NetUtils.GetPacketBuffer(e.Buffer, dataStartOffset, rest);

                        token.MessageData = token.MessageData?.Concat(remainingBuffer).ToArray() ?? remainingBuffer;

                        token.ReceivedMessageBytesCount += remainingBuffer.Length;
                        token.DataStartOffset += remainingBuffer.Length;
                        alreadyProcessedDataSize += rest;
                    }

                    if (token.ReceivedMessageBytesCount != messageSize || token.MessageData == null)
                        continue;

                    token.MessageHandler?.Invoke(token.MessageData);
                    token.ReceivedMessageBytesCount = 0;
                    token.MessageData = null;
                    token.MessageSize = null;
                }
            }
        }

        public static void ProcessNextReceive(SocketAsyncEventArgs e, IAsyncUserToken token)
        {
            token.NextReceiveOffset += e.BytesTransferred;

            if (token.NextReceiveOffset == e.Buffer.Length)
            {
                token.NextReceiveOffset = 0;

                if (token.DataStartOffset < e.Buffer.Length)
                {
                    int notYesProcessDataSize = e.Buffer.Length - token.DataStartOffset;
                    Buffer.BlockCopy(e.Buffer, token.DataStartOffset, e.Buffer, 0, notYesProcessDataSize);

                    token.NextReceiveOffset = notYesProcessDataSize;
                }

                token.DataStartOffset = 0;
            }

            e.SetBuffer(token.NextReceiveOffset, e.Buffer.Length - token.NextReceiveOffset);
        }
    }
}
