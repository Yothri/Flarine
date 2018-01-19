using Ether.Network.Interfaces;

namespace Flarine.Network.ISC.Handler
{
    public abstract class ISCHandler
    {
        public abstract INetPacketStream Handle(INetPacketStream stream);
    }
}