using ClientCommon;
using Flarine.Game.Network.Photon.Common;

namespace Flarine.Game.Network.Photon.Handler.Command
{
    internal sealed class LoginHandler<T> : OperationHandler<T> where T : Body
    {
        public override void Handle(PhotonGameConnection connection, T requestBody)
        {

        }
    }
}