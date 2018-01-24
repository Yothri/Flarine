using System.Linq;
using ClientCommon;
using ClientCommon.CommandBody;
using Flarine.Game.Network.Photon.Common;

namespace Flarine.Game.Network.Photon.Handler.Command
{
    internal sealed class ChangeHeroHandler<T> : OperationHandler<T> where T : ChangeHeroCommandBody
    {
        public override void Handle(PhotonGameConnection connection, T requestBody)
        {
            var session = GameContext.GameSessions
                .Where(s => s.NetUser == connection)
                .FirstOrDefault();

            if (session == null) return;

            session.SelectedPlayCharacter = requestBody.targetAccountHeroId;

            connection.SendResponse(new ChangeHeroResponseBody(), ClientCommandName.kCommand_ChangeHero);
        }
    }
}