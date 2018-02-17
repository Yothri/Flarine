using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Ether.Network.Client;
using Ether.Network.Packets;
using Flarine.Core.Context;
using Flarine.Core.Logging;
using Flarine.Core.Network.ISC;
using Flarine.Game.Network.ISC.Handler;
using Flarine.Network.ISC.Handler;
using Microsoft.Extensions.Logging;

namespace Flarine.Game.Network.ISC
{
    internal sealed class ISCClient : NetClient
    {
        public ISCClient()
        {
            Configuration.Host = ContextBase.GetInstance<GameContext>().GameConfig.LoginISCHost;
            Configuration.Port = ContextBase.GetInstance<GameContext>().GameConfig.LoginISCPort;
            Configuration.BufferSize = 8192;
        }

        protected override void OnConnected()
        {
            Logger.Get<ISCClient>().LogInformation("Connection to LoginISC has been established.");

            var gsConfig = ContextBase.GetInstance<GameContext>().GameConfig.GameServerConfig;
            using (var packet = new NetPacket())
            {
                packet.Write((short)OpCode.REGISTER_GS);
                packet.Write(gsConfig.VirtualGameServerId);
                packet.Write(gsConfig.GameServerId);
                packet.Write(gsConfig.GroupId);
                packet.Write(gsConfig.DisplayNo);
                packet.Write(gsConfig.Name);
                packet.Write(gsConfig.ApiUrl);
                packet.Write(gsConfig.ProxyGameServerIp);
                packet.Write(gsConfig.ProxyGameServerPort);
                packet.Write(gsConfig.IsMaintenance);
                packet.Write(gsConfig.PkEnabled);
                packet.Write(gsConfig.TimeZone);
                packet.Write(gsConfig.StateCode);
                packet.Write(gsConfig.IsRecommend);
                Send(packet);
            }
        }

        public override void HandleMessage(INetPacketStream packet)
        {
            base.HandleMessage(packet);

            OpCode code = (OpCode)packet.Read<short>();
            var type = default(Type);
            if (!Handlers.TryGetValue(code, out type))
                Logger.Get<ISCClient>().LogWarning($"Unhandled ISC OpCode {Enum.GetName(typeof(OpCode), code)}.");
            else
            {
                var response = (Activator.CreateInstance(type) as ISCHandler).Handle(this, packet);
                if (response != null)
                    Send(response);
            }
        }

        protected override void OnDisconnected()
        {
            Logger.Get<ISCClient>().LogInformation("Connection from LoginISC has been dropped.");
        }

        protected override void OnSocketError(SocketError socketError)
        {
            Logger.Get<ISCClient>().LogError($"Socket Error {Enum.GetName(typeof(SocketError), socketError)} occured.");
        }

        private readonly Dictionary<OpCode, Type> Handlers = new Dictionary<OpCode, Type>
        {
            { OpCode.REGISTER_GS, typeof(RegisterGameServerHandler) },
            { OpCode.REGISTER_USER, typeof(RegisterUserHandler) }
        };
    }
}