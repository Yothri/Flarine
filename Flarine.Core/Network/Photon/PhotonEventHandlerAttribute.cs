using System;
using ClientCommon;

namespace Flarine.Core.Network.Photon
{
    public class PhotonEventHandlerAttribute : Attribute
    {
        public PhotonEventHandlerAttribute(ClientEventName eventName, Type commandBody)
        {
            Event = eventName;
            CommandBody = commandBody;
        }

        public ClientEventName Event { get; private set; }
        public Type CommandBody { get; private set; }
    }
}