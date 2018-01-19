using System;
using System.Collections.Generic;
using Ether.Network.Interfaces;
using Flarine.Network.ISC.Common;

namespace Flarine.Login.Network.ISC.Common
{
    internal sealed class LoginISCConnection : ISCConnection
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