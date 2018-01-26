using System;
using System.Collections.Generic;
using Ether.Network.Packets;
using Flarine.Core.Log;
using Flarine.Core.Network.ISC;
using Flarine.Login.Network.ISC.Handler;
using Flarine.Network.ISC.Common;
using Flarine.Network.ISC.Handler;

namespace Flarine.Login.Network.ISC.Common
{
    internal sealed class LoginISCConnection : ISCConnection
    {
        public override void HandleMessage(INetPacketStream packet)
        {
            base.HandleMessage(packet);

            OpCode code = (OpCode)packet.Read<short>();
            var type = default(Type);
            if (!Handlers.TryGetValue(code, out type))
                Logger.Log($"Unhandled ISC OpCode {Enum.GetName(typeof(OpCode), code)}.", LogLevel.Warning);
            else
            {
                var response = (Activator.CreateInstance(type) as ISCHandler).Handle(this, packet);
                if (response != null)
                    Send(response);
            }
        }

        protected override Dictionary<OpCode, Type> Handlers => new Dictionary<OpCode, Type>
        {
            { OpCode.REGISTER_GS, typeof(RegisterGameServerHandler) }
        };
    }
}