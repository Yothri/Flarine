using System;
using System.Collections.Generic;
using Ether.Network;
using Flarine.Core.Network.ISC;

namespace Flarine.Network.ISC.Common
{
    public abstract class ISCConnection : NetUser
    {
        protected abstract Dictionary<OpCode, Type> Handlers { get; }
    }
}