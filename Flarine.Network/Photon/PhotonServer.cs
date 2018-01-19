using Ether.Network;
using Ether.Network.Interfaces;
using Flarine.Network.Photon.Common;

namespace Flarine.Network.Photon
{
    public abstract class PhotonServer : NetServer<PhotonConnection>
    {
        protected override IPacketProcessor PacketProcessor => new PhotonPacketProcessor();
    }
}