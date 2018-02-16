using System.Collections.Generic;

namespace Flarine.Network.Photon.IO.Protocol
{
    public class EventData
    {
        public object this[byte key]
        {
            get
            {
                object result;
                this.Parameters.TryGetValue(key, out result);
                return result;
            }
            set
            {
                this.Parameters[key] = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Event {0}.", this.Code.ToString());
        }

        public string ToStringFull()
        {
            return string.Format("Event {0}: {1}", this.Code, SupportClass.DictionaryToString(this.Parameters));
        }

        public EventData()
        {
        }

        public byte Code;

        public Dictionary<byte, object> Parameters;
    }
}