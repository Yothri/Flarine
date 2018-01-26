using Ether.Network.Common;
using Ether.Network.Packets;

namespace Flarine.Network.ISC.Handler
{
    public abstract class ISCHandler
    {
        public abstract INetPacketStream Handle(NetUser connection, INetPacketStream stream);
    }
}