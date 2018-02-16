using System.Linq;
using ClientCommon;
using ClientCommon.CommandBody;
using ClientCommon.PacketData;
using Flarine.Core.Network.Photon;
using Flarine.Game.Network.Photon.Common;
using Microsoft.EntityFrameworkCore;

namespace Flarine.Game.Network.Photon.Handler.Command
{
    [PhotonCommandHandler(ClientCommandName.kCommand_EnterPortal, typeof(EnterPortalCommandBody))]
    internal sealed class EnterPortalHandler<T> : OperationHandler<T> where T : EnterPortalCommandBody
    {
        public override void Handle(PhotonGameConnection connection, T requestBody)
        {
            var session = GameContext.GameSessions
                .Where(s => s.Connection == connection)
                .FirstOrDefault();

            if (session == null) return;

            var hero = DataContext.Accounts
                .Where(a => a.UserId == session.User.UserId)
                .Include(a => a.AccountHeros)
                .FirstOrDefault()
                .AccountHeros
                .Where(h => h.Id == session.SelectedPlayCharacter)
                .FirstOrDefault();

            connection.SendResponse(new EnterPortalResponseBody
            {
                accountHeroes = new PDAccountHero[] { },
                dropObjects = new PDDropObject[] { },
                monsters = new PDMonsterInstance[] { },
                arenaStatue = new PDArenaStatue() { },
                myAccountHero = new PDAccountHero
                {
                    accountHeroId = hero.Id,
                    name = hero.Name,
                    level = hero.Level,
                    abnormalStateEffects = new PDAbnormalStateEffect[] { },
                    equippedGearExs = new PDAccountHeroGearEx[] { },
                    equippedGears = new PDAccountHeroGear[] { },
                    position = new PDVector3(0, 0, 0),
                    isGM = true
                }
            }, ClientCommandName.kCommand_EnterPortal);
        }
    }
}