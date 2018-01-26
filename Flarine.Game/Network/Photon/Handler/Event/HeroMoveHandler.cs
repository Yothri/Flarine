﻿using System.Linq;
using System.Numerics;
using ClientCommon;
using ClientCommon.ClientEventBody;
using ClientCommon.PacketData;
using ClientCommon.ServerEventBody;
using Flarine.Core.Network.Photon;
using Flarine.Game.Network.Photon.Common;

namespace Flarine.Game.Network.Photon.Handler.Event
{
    [PhotonEventHandler(ClientEventName.kEvent_HeroMove, typeof(CEBHeroMoveEventBody))]
    internal sealed class HeroMoveHandler<T> : OperationHandler<T> where T : CEBHeroMoveEventBody
    {
        public override void Handle(PhotonGameConnection connection, T requestBody)
        {
            var session = GameContext.GameSessions
                .Where(s => s.Connection == connection)
                .FirstOrDefault();

            var hero = session.AccountHeros
                .Where(h => h.AccountHeroId == requestBody.accountHeroId)
                .FirstOrDefault();

            hero.Position = new Vector3(requestBody.position.x, requestBody.position.y, requestBody.position.z);
            hero.RotationY = requestBody.rotationY;

            // send position update to other clients

            GameContext.GameSessions
                .Where(s => s.Connection != null && s.Connection != connection)
                .ToList()
                .ForEach(s => s.Connection.SendEvent(new SEBHeroMoveEventBody
                {
                    accountHeroId = requestBody.accountHeroId,
                    position = requestBody.position,
                    rotationY = requestBody.rotationY
                }, ServerEventName.kEvent_HeroMove));
        }
    }
}