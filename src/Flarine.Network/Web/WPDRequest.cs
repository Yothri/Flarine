using System;
using Newtonsoft.Json;

namespace Flarine.Network.Web
{
    public abstract class WPDRequest : IDisposable
    {
        public abstract WPDResponse Handle();

        [JsonProperty("cmd")]
        public string Cmd { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {

            }
        }
    }
}