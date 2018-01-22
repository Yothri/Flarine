using System.Linq;
using ClientCommon.CommandBody;
using Flarine.Game.Network.Photon.Common;

namespace Flarine.Game.Network.Photon.Handler.Command
{
    internal sealed class LoginHandler<T> : OperationHandler<T> where T : LoginCommandBody
    {
        public override void Handle(PhotonGameConnection connection, T requestBody)
        {
            var session = GameContext.GameSessions
                .Where(s => s.GameAccessToken == requestBody.accessToken).FirstOrDefault();

            if (session == null)
                return;

            // Associate PhotonConnection with GameSession.
            session.NetUser = connection;

            connection.SendResponse(new LoginResponseBody(), ClientCommon.ClientCommandName.kCommand_Login);
        }
    }
}