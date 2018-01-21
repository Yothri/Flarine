using ClientCommon;
using Flarine.Core.Context;
using Flarine.Game.Network.Photon.Common;

namespace Flarine.Game.Network.Photon.Handler
{
    internal abstract class OperationHandler<T> where T : Body
    {
        public abstract void Handle(PhotonGameConnection connection, T requestBody);

        protected GameContext GameContext { get => ContextBase.GetInstance<GameContext>(); }
    }
}