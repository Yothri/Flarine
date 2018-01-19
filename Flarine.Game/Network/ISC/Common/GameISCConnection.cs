using System;
using System.Collections.Generic;
using Ether.Network.Interfaces;
using Flarine.Network.ISC.Common;

namespace Flarine.Game.Network.ISC.Common
{
    internal sealed class GameISCConnection : ISCConnection
    {
        public override void HandleMessage(INetPacketStream packet)
        {
            base.HandleMessage(packet);

        }

        protected override Dictionary<short, Type> Handlers => new Dictionary<short, Type>
        {

        };
    }
}