using System.Linq;
using Ether.Network.Common;
using Ether.Network.Packets;
using Flarine.Core.Context;
using Flarine.Core.Context.Model;
using Flarine.Core.Log;
using Flarine.Core.Network.ISC;
using Flarine.Network.ISC.Handler;

namespace Flarine.Login.Network.ISC.Handler
{
    internal sealed class RegisterGameServerHandler : ISCHandler
    {
        public override INetPacketStream Handle(NetUser connection, INetPacketStream stream)
        {
            var ctx = ContextBase.GetInstance<LoginContext>();
            var gameServer = new GameServer
            {
                VirtualGameServerId = stream.Read<int>(),
                GameServerId = stream.Read<int>(),
                GroupId = stream.Read<int>(),
                DisplayNo = stream.Read<int>(),
                Name = stream.Read<string>(),
                ApiUrl = stream.Read<string>(),
                ProxyGameServerIp = stream.Read<string>(),
                ProxyGameServerPort = stream.Read<int>(),
                IsMaintenance = stream.Read<bool>(),
                PkEnabled = stream.Read<bool>(),
                TimeZone = stream.Read<string>(),
                StateCode = stream.Read<int>(),
                IsRecommend = stream.Read<bool>()
            };
            
            var packet = new NetPacket();
            packet.Write((short)OpCode.REGISTER_GS);
            if (ctx.GameServers.Values.Any(g => g.GameServerId == gameServer.GameServerId || g.VirtualGameServerId == gameServer.VirtualGameServerId))
            {
                packet.Write(false);
                Logger.Log($"GameServer registration for {gameServer.Name} with id {gameServer.GameServerId} was rejected.");
            }
            else
            {
                ctx.GameServers.Add(connection, gameServer);
                packet.Write(true);
                Logger.Log($"GameServer registration for {gameServer.Name} with id {gameServer.GameServerId} was granted.");
            }
            return packet;
        }
    }
}