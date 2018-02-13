using Ether.Network.Common;
using Ether.Network.Packets;
using Flarine.Core.Logging;
using Flarine.Network.ISC.Handler;
using Microsoft.Extensions.Logging;

namespace Flarine.Game.Network.ISC.Handler
{
    internal sealed class RegisterGameServerHandler : ISCHandler
    {
        public override INetPacketStream Handle(NetUser connection, INetPacketStream stream)
        {
            if (stream.Read<bool>())
                Logger.Get<RegisterGameServerHandler>().LogInformation("GameServer registration has been granted.");
            else
                Logger.Get<RegisterGameServerHandler>().LogWarning("GameServer registration has been refused.");

            return null;
        }
    }
}