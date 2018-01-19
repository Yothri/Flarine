using System;
using System.Collections.Generic;
using Ether.Network;

namespace Flarine.Network.ISC.Common
{
    public abstract class ISCConnection : NetUser
    {
        protected abstract Dictionary<short, Type> Handlers { get; }
    }
}