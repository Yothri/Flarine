using Ether.Network.Common;
using Ether.Network.Packets;
using Flarine.Core.Log;
using Flarine.Network.ISC.Handler;

namespace Flarine.Game.Network.ISC.Handler
{
    internal sealed class RegisterGameServerHandler : ISCHandler
    {
        public override INetPacketStream Handle(NetUser connection, INetPacketStream stream)
        {
            if (stream.Read<bool>())
                Logger.Log("GameServer registration has been granted.");
            else
                Logger.Log("GameServer registration has been refused.", LogLevel.Warning);

            return null;
        }
    }
}