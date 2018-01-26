using System;
using Ether.Network.Server;
using Flarine.Core.Context;
using Flarine.Core.Context.Model;
using Flarine.Core.Log;
using Flarine.Login.Network.ISC.Common;

namespace Flarine.Login.Network.ISC
{
    internal sealed class ISCServer : NetServer<LoginISCConnection>
    {
        public ISCServer()
        {
            Configuration.Host = ContextBase.GetInstance<LoginContext>().LoginConfig.ISCServerHost;
            Configuration.Port = ContextBase.GetInstance<LoginContext>().LoginConfig.ISCServerPort;
            Configuration.Blocking = false;
            Configuration.BufferSize = 8192;
            Configuration.Backlog = 5;
            Configuration.MaximumNumberOfConnections = 50;
        }

        protected override void Initialize()
        {
            Logger.Log($"ISCServer is about to start listening on {Configuration.Host}:{Configuration.Port}");
        }

        protected override void OnClientConnected(LoginISCConnection connection)
        {
            Logger.Log($"{connection.Socket.RemoteEndPoint.ToString()} connected to ISCServer.");
        }

        protected override void OnClientDisconnected(LoginISCConnection connection)
        {
            Logger.Log($"{connection.Socket.RemoteEndPoint.ToString()} disconnected from ISCServer.");

            if(ContextBase.GetInstance<LoginContext>().GameServers.TryGetValue(connection, out GameServer gameServer))
            {
                Logger.Log($"GameServer {gameServer.Name} with id {gameServer.GameServerId} deregistered.");
                ContextBase.GetInstance<LoginContext>().GameServers.Remove(connection);
            }
        }

        protected override void OnError(Exception exception)
        {
            Logger.Log($"{exception.StackTrace}", LogLevel.Exception);
        }
    }
}