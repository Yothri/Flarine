using Ether.Network.Packets;
using Ether.Network.Server;
using Flarine.Network.Photon.Common;

namespace Flarine.Network.Photon
{
    public abstract class PhotonServer<T> : NetServer<T> where T : PhotonConnection, new()
    {
        protected override IPacketProcessor PacketProcessor => new PhotonPacketProcessor();
    }
}