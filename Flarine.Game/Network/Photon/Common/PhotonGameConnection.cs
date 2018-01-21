using Ether.Network.Interfaces;
using Flarine.Network.Photon.Common;

namespace Flarine.Game.Network.Photon.Common
{
    internal sealed class PhotonGameConnection : PhotonConnection
    {
        protected override void HandleOperationRequest(INetPacketStream packet)
        {
            base.HandleOperationRequest(packet);


        }
    }
}