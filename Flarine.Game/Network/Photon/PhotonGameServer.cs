using System;
using System.Reflection;
using Flarine.Core.Context;
using Flarine.Core.Log;
using Flarine.Core.Network.Photon;
using Flarine.Game.Network.Photon.Common;
using Flarine.Network.Photon;

namespace Flarine.Game.Network.Photon
{
    internal sealed class PhotonGameServer : PhotonServer<PhotonGameConnection>
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
            foreach(var t in Assembly.GetExecutingAssembly().GetTypes())
            {
                foreach(var attr in t.GetCustomAttributes(true))
                {
                    if (attr.GetType() == typeof(PhotonCommandHandlerAttribute))
                    {
                        var cmdAttr = attr as PhotonCommandHandlerAttribute;
                        PhotonGameConnection.CommandHandlers.Add(cmdAttr.Command, t.MakeGenericType(cmdAttr.CommandBody));
                    }
                    else if(attr.GetType() == typeof(PhotonEventHandlerAttribute))
                    {
                        var cmdAttr = attr as PhotonEventHandlerAttribute;
                        PhotonGameConnection.EventHandlers.Add(cmdAttr.Event, t.MakeGenericType(cmdAttr.CommandBody));
                    }
                }
            }

            Logger.Log($"Loaded {PhotonGameConnection.CommandHandlers.Count} CommandHandlers and {PhotonGameConnection.EventHandlers.Count} EventHandlers.");
            Logger.Log($"PhotonGameServer is about to start listening on {Configuration.Host}:{Configuration.Port}");
        }

        protected override void OnClientConnected(PhotonGameConnection connection)
        {
            Logger.Log($"{connection.Socket.RemoteEndPoint.ToString()} connected to GameServer.");
        }

        protected override void OnClientDisconnected(PhotonGameConnection connection)
        {
            Logger.Log($"{connection.Socket.RemoteEndPoint.ToString()} disconnected from GameServer.");
        }

        protected override void OnError(Exception exception)
        {
            Logger.Log($"{exception.StackTrace}", LogLevel.Exception);
        }
    }
}