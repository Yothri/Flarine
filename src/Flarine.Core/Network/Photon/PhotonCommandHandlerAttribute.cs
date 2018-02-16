using System;
using ClientCommon;

namespace Flarine.Core.Network.Photon
{
    public class PhotonCommandHandlerAttribute : Attribute
    {
        public PhotonCommandHandlerAttribute(ClientCommandName command, Type commandBody)
        {
            Command = command;
            CommandBody = commandBody;
        }

        public ClientCommandName Command { get; private set; }
        public Type CommandBody { get; private set; }
    }
}