using Ether.Network;
using Ether.Network.Interfaces;

namespace Flarine.Network.ISC.Handler
{
    public abstract class ISCHandler
    {
        public abstract INetPacketStream Handle(NetUser connection, INetPacketStream stream);
    }
}