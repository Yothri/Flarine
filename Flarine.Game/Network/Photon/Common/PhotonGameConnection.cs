using System;
using System.Collections.Generic;
using ClientCommon;
using ClientCommon.CommandBody;
using Flarine.Core.Log;
using Flarine.Game.Network.Photon.Handler.Command;
using Flarine.Network.Photon.Common;
using Flarine.Network.Photon.IO.Protocol;

namespace Flarine.Game.Network.Photon.Common
{
    internal sealed class PhotonGameConnection : PhotonConnection
    {
        protected override void HandleOperationRequest(OperationRequest request)
        {
            base.HandleOperationRequest(request);

            if(request.OperationCode == 0)
            {
                if (CommandHandlers.TryGetValue((ClientCommandName)request.Parameters[0], out Type type))
                {
                    var constraint = type.GetGenericArguments()[0];
                    var handleAction = type.GetMethod("Handle");
                    var activator = Activator.CreateInstance(type);
                    handleAction.Invoke(activator, new object[] { this, Body.DeserializeRaw((byte[])request.Parameters[2], constraint, out long InReadCount) });
                    Logger.Log($"{Enum.GetName(typeof(ClientCommandName), request.Parameters[0])} Request from {Socket.RemoteEndPoint.ToString()}");
                }
                else
                    Logger.Log($"Unhandled {Enum.GetName(typeof(ClientCommandName), request.Parameters[0])} Request from {Socket.RemoteEndPoint.ToString()}");
            }
            else
            {
                if (EventHandlers.TryGetValue((ClientEventName)request.Parameters[0], out Type type))
                {
                    var constraint = type.GetGenericArguments()[0];
                    var handleAction = type.GetMethod("Handle");
                    var activator = Activator.CreateInstance(type);
                    handleAction.Invoke(activator, new object[] { this, Body.DeserializeRaw((byte[])request.Parameters[1], constraint, out long InReadCount) });
                    Logger.Log($"{Enum.GetName(typeof(ClientEventName), request.Parameters[0])} Request from {Socket.RemoteEndPoint.ToString()}");
                }
                else
                    Logger.Log($"Unhandled {Enum.GetName(typeof(ClientEventName), request.Parameters[0])} Request from {Socket.RemoteEndPoint.ToString()}");
            }
        }

        private Dictionary<ClientCommandName, Type> CommandHandlers = new Dictionary<ClientCommandName, Type>
        {
            { ClientCommandName.kCommand_Login,  typeof(LoginHandler<LoginCommandBody>) },
            { ClientCommandName.kCommand_ChangeHero, typeof(ChangeHeroHandler<ChangeHeroCommandBody>) },
            { ClientCommandName.kCommand_MyAccountHeroInfo, typeof(MyAccountHeroInfoHandler<MyAccountHeroInfoCommandBody>) },
            { ClientCommandName.kCommand_HeroLogin, typeof(HeroLoginHandler<HeroLoginCommandBody>) }
        };

        private Dictionary<ClientEventName, Type> EventHandlers = new Dictionary<ClientEventName, Type>
        {

        };
    }
}