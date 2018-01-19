using System.Collections.Generic;

namespace Flarine.Network.Photon.IO.Protocol
{
    public class OperationRequest
    {
        public OperationRequest()
        {
        }

        public byte OperationCode;

        public Dictionary<byte, object> Parameters;
    }
}