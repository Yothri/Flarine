using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Ether.Network;
using Ether.Network.Interfaces;
using Ether.Network.Packets;
using Flarine.Core.Context;
using Flarine.Core.Log;
using Flarine.Core.Network.ISC;
using Flarine.Game.Network.ISC.Handler;
using Flarine.Network.ISC.Handler;

namespace Flarine.Game.Network.ISC
{
    internal sealed class ISCClient : NetClient
    {
        public ISCClient() : base(ContextBase.GetInstance<GameContext>().GameConfig.LoginISCHost, ContextBase.GetInstance<GameContext>().GameConfig.LoginISCPort, 8192)
        {
            
        }

        protected override void OnConnected()
        {
            Logger.Log("Connection to LoginISC has been established.");

            using (var packet = new NetPacket())
            {
                // Fill packet with GS data.
                Send(packet);
            }
        }

        public override void HandleMessage(INetPacketStream packet)
        {
            base.HandleMessage(packet);

            OpCode code = (OpCode)packet.Read<short>();
            var type = default(Type);
            if (!Handlers.TryGetValue(code, out type))
                Logger.Log($"Unhandled ISC OpCode {Enum.GetName(typeof(OpCode), code)}.", LogLevel.Warning);
            else
                (Activator.CreateInstance(type) as ISCHandler).Handle(packet);
        }

        protected override void OnDisconnected()
        {
            Logger.Log("Connection from LoginISC has been dropped.");
        }

        protected override void OnSocketError(SocketError socketError)
        {
            Logger.Log($"Socket Error {Enum.GetName(typeof(SocketError), socketError)} occured.", LogLevel.Error);
        }

        private readonly Dictionary<OpCode, Type> Handlers = new Dictionary<OpCode, Type>
        {
            { OpCode.REGISTER_GS, typeof(RegisterGameServerHandler) }
        };
    }
}