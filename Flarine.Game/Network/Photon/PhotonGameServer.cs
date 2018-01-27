using System;
using System.Linq;
using System.Reflection;
using ClientCommon;
using ClientCommon.ServerEventBody;
using Flarine.Core.Context;
using Flarine.Core.Log;
using Flarine.Core.Network.Photon;
using Flarine.Database;
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
            var session = ContextBase.GetInstance<GameContext>().GameSessions
                .Where(s => s.Connection == connection)
                .FirstOrDefault();

            using (var dbCtx = DatabaseService.GetContext())
            {
                var hero = dbCtx.Heros
                    .Where(h => h.Id == session.SelectedPlayCharacter)
                    .FirstOrDefault();

                var character = session.AccountHeros
                    .Where(h => h.AccountHeroId == session.SelectedPlayCharacter)
                    .FirstOrDefault();

                hero.X = character.Position.X;
                hero.Y = character.Position.Y;
                hero.Z = character.Position.Z;
                hero.RotationY = character.RotationY;
                dbCtx.SaveChanges();
            }

            // disconnect user to other clients
            GameContext.GameSessions
                .Where(s => s.Connection != null && s.Connection != connection)
                .ToList()
                .ForEach(s => s.Connection.SendEvent(new SEBHeroExitEventBody
                {
                    accountHeroId = session.SelectedPlayCharacter
                }, ServerEventName.kEvent_HeroExit));

            GameContext.GameSessions.Remove(session);


            Logger.Log($"{connection.Socket.RemoteEndPoint.ToString()} disconnected from GameServer.");
        }

        protected override void OnError(Exception exception)
        {
            Logger.Log($"{exception.StackTrace}", LogLevel.Exception);
        }

        private GameContext GameContext => ContextBase.GetInstance<GameContext>();
    }
}