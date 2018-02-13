using System;
using System.Collections.Generic;
using System.Linq;
using ClientCommon;
using Flarine.Core.Logging;
using Flarine.Network.Photon.Common;
using Flarine.Network.Photon.IO.Protocol;
using Microsoft.Extensions.Logging;

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
                    Logger.Get<PhotonGameConnection>().LogInformation($"{Enum.GetName(typeof(ClientCommandName), request.Parameters[0])} Request from {Socket.RemoteEndPoint.ToString()}");
                }
                else
                    Logger.Get<PhotonGameConnection>().LogWarning($"Unhandled {Enum.GetName(typeof(ClientCommandName), request.Parameters[0])} Request from {Socket.RemoteEndPoint.ToString()}");
            }
            else
            {
                if (EventHandlers.TryGetValue((ClientEventName)request.Parameters[0], out Type type))
                {
                    var constraint = type.GetGenericArguments()[0];
                    var handleAction = type.GetMethod("Handle");
                    var activator = Activator.CreateInstance(type);
                    handleAction.Invoke(activator, new object[] { this, Body.DeserializeRaw((byte[])request.Parameters[1], constraint, out long InReadCount) });
                    
                    if(!EventLoggingBlacklist.Any(t => t == (ClientEventName)request.Parameters[0]))
                        Logger.Get<PhotonGameConnection>().LogInformation($"{Enum.GetName(typeof(ClientEventName), request.Parameters[0])} Request from {Socket.RemoteEndPoint.ToString()}");
                }
                else
                    Logger.Get<PhotonGameConnection>().LogWarning($"Unhandled {Enum.GetName(typeof(ClientEventName), request.Parameters[0])} Request from {Socket.RemoteEndPoint.ToString()}");
            }
        }

        public static readonly Dictionary<ClientCommandName, Type> CommandHandlers = new Dictionary<ClientCommandName, Type>();
        public static readonly Dictionary<ClientEventName, Type> EventHandlers = new Dictionary<ClientEventName, Type>();
        public static readonly List<ClientEventName> EventLoggingBlacklist = new List<ClientEventName>
        {
            ClientEventName.kEvent_HeroMove,
            ClientEventName.kEvent_HeroMoveStart,
            ClientEventName.kEvent_HeroMoveEnd
        };
    }
}