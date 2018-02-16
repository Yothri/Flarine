using ClientCommon;
using ClientCommon.ClientEventBody;
using Flarine.Core.Network.Photon;
using Flarine.Game.Network.Photon.Common;

namespace Flarine.Game.Network.Photon.Handler.Event
{
    [PhotonEventHandler(ClientEventName.kEvent_HeroMoveEnd, typeof(CEBHeroMoveEndEventBody))]
    internal sealed class HeroMoveEndHandler<T> : OperationHandler<T> where T : CEBHeroMoveEndEventBody
    {
        public override void Handle(PhotonGameConnection connection, T requestBody)
        {

        }
    }
}