using System.Linq;
using ClientCommon.CommandBody;
using Flarine.Core.Network.Photon;
using Flarine.Game.Network.Photon.Common;

namespace Flarine.Game.Network.Photon.Handler.Command
{
    [PhotonCommandHandler(ClientCommon.ClientCommandName.kCommand_Login, typeof(LoginCommandBody))]
    internal sealed class LoginHandler<T> : OperationHandler<T> where T : LoginCommandBody
    {
        public override void Handle(PhotonGameConnection connection, T requestBody)
        {
            var session = GameContext.GameSessions
                .Where(s => s.User.GameAccessToken == requestBody.accessToken).FirstOrDefault();

            if (session == null)
                return;

            // Associate PhotonConnection with GameSession.
            session.Connection = connection;

            connection.SendResponse(new LoginResponseBody(), ClientCommon.ClientCommandName.kCommand_Login);
        }
    }
}