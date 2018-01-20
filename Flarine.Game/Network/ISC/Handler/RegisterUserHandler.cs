using Ether.Network;
using Ether.Network.Interfaces;
using Flarine.Core.Context;
using Flarine.Core.Context.Model;
using Flarine.Network.ISC.Handler;

namespace Flarine.Game.Network.ISC.Handler
{
    internal sealed class RegisterUserHandler : ISCHandler
    {
        public override INetPacketStream Handle(NetUser connection, INetPacketStream stream)
        {
            var userId = stream.Read<string>();
            var accessToken = stream.Read<string>();

            ContextBase.GetInstance<GameContext>().LoginSessions.Add(new LoginSession
            {
                User = new User
                {
                    UserId = userId,
                    AccessToken = accessToken
                }
            });

            return null;
        }
    }
}