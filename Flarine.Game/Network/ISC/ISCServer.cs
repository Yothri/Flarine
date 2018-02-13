using System;
using Ether.Network.Server;
using Flarine.Core.Context;
using Flarine.Core.Logging;
using Flarine.Game.Network.ISC.Common;
using Microsoft.Extensions.Logging;

namespace Flarine.Game.Network.ISC
{
    internal sealed class ISCServer : NetServer<GameISCConnection>
    {
        public ISCServer()
        {
            Configuration.Host = ContextBase.GetInstance<GameContext>().GameConfig.ISCServerHost;
            Configuration.Port = ContextBase.GetInstance<GameContext>().GameConfig.ISCServerPort;
            Configuration.Blocking = false;
            Configuration.BufferSize = 8192;
            Configuration.Backlog = 5;
            Configuration.MaximumNumberOfConnections = 5;
        }

        protected override void Initialize()
        {
            Logger.Get<ISCServer>().LogInformation($"ISCServer is about to start listening on {Configuration.Host}:{Configuration.Port}");
        }

        protected override void OnClientConnected(GameISCConnection connection)
        {
            Logger.Get<ISCServer>().LogInformation($"{connection.Socket.RemoteEndPoint.ToString()} connected to ISCServer.");
        }

        protected override void OnClientDisconnected(GameISCConnection connection)
        {
            Logger.Get<ISCServer>().LogInformation($"{connection.Socket.RemoteEndPoint.ToString()} disconnected from ISCServer.");
        }

        protected override void OnError(Exception exception)
        {
            Logger.Get<ISCServer>().LogTrace($"{exception.StackTrace}");
        }
    }
}