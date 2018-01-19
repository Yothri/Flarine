﻿using System.Collections.Generic;

namespace Flarine.Network.Photon.IO.Protocol
{
    public class OperationResponse
    {
        public object this[byte parameterCode]
        {
            get
            {
                object result;
                this.Parameters.TryGetValue(parameterCode, out result);
                return result;
            }
            set
            {
                this.Parameters[parameterCode] = value;
            }
        }

        public override string ToString()
        {
            return string.Format("OperationResponse {0}: ReturnCode: {1}.", this.OperationCode, this.ReturnCode);
        }

        public string ToStringFull()
        {
            return string.Format("OperationResponse {0}: ReturnCode: {1} ({3}). Parameters: {2}", new object[]
            {
                this.OperationCode,
                this.ReturnCode,
                SupportClass.DictionaryToString(this.Parameters),
                this.DebugMessage
            });
        }

        public OperationResponse()
        {
        }

        public byte OperationCode;

        public short ReturnCode;

        public string DebugMessage;

        public Dictionary<byte, object> Parameters;
    }
}