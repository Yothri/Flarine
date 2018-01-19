using Ether.Network.Interfaces;

namespace Flarine.Network.ISC.Handler
{
    public abstract class ISCHandler
    {
        public abstract void Handle(INetPacketStream stream);
    }
}