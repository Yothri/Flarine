using System.Linq;
using ClientCommon.CommandBody;
using Flarine.Core.Network.Photon;
using Flarine.Game.Network.Photon.Common;

namespace Flarine.Game.Network.Photon.Handler.Command
{
    [PhotonCommandHandler(ClientCommon.ClientCommandName.kCommand_MyAccountHeroInfo, typeof(MyAccountHeroInfoCommandBody))]
    internal sealed class MyAccountHeroInfoHandler<T> : OperationHandler<T> where T : MyAccountHeroInfoCommandBody
    {
        public override void Handle(PhotonGameConnection connection, T requestBody)
        {
            var hero = DataContext.Heros
                .Where(h => h.Id == requestBody.accountHeroId)
                .FirstOrDefault();

            if (hero == null)
                throw new System.Exception("Blabla");

            connection.SendResponse(new MyAccountHeroInfoResponseBody
            {
                continentId = hero.ContinentId
            }, ClientCommon.ClientCommandName.kCommand_MyAccountHeroInfo);
        }
    }
}