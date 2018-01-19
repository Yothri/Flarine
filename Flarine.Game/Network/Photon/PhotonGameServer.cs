using System;
using Flarine.Core.Context;
using Flarine.Core.Log;
using Flarine.Network.Photon;
using Flarine.Network.Photon.Common;

namespace Flarine.Game.Network.Photon
{
    internal sealed class PhotonGameServer : PhotonServer
    {
        public PhotonGameServer()
        {
            Configuration.Host = ContextBase.GetInstance<GameContext>().GameConfig.GameServerHost;
            Configuration.Port = ContextBase.GetInstance<GameContext>().GameConfig.GameServerPort;
            Configuration.Blocking = false;
            Configuration.BufferSize = 8192;
            Configuration.Backlog = 100;
            Configuration.MaximumNumberOfConnections = ContextBase.GetInstance<GameContext>().GameConfig.MaxGameServerConnections;
        }

        protected override void Initialize()
        {
            Logger.Log($"PhotonGameServer is about to start listening on {Configuration.Host}:{Configuration.Port}");
        }

        protected override void OnClientConnected(PhotonConnection connection)
        {
            Logger.Log($"{connection.Socket.RemoteEndPoint.ToString()} connected to GameServer.");
        }

        protected override void OnClientDisconnected(PhotonConnection connection)
        {
            Logger.Log($"{connection.Socket.RemoteEndPoint.ToString()} disconnected from GameServer.");
        }

        protected override void OnError(Exception exception)
        {
            Logger.Log($"{exception.StackTrace}", LogLevel.Exception);
        }
    }
}