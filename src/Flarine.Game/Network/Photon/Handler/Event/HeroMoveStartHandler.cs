using ClientCommon;
using ClientCommon.ClientEventBody;
using Flarine.Core.Network.Photon;
using Flarine.Game.Network.Photon.Common;

namespace Flarine.Game.Network.Photon.Handler.Event
{
    [PhotonEventHandler(ClientEventName.kEvent_HeroMoveStart, typeof(CEBHeroMoveStartEventBody))]
    internal sealed class HeroMoveStartHandler<T> : OperationHandler<T> where T : CEBHeroMoveStartEventBody
    {
        public override void Handle(PhotonGameConnection connection, T requestBody)
        {
            
        }
    }
}