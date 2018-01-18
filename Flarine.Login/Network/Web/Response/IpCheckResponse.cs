using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Response
{
    internal sealed class IpCheckResponse : WPDResponse
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}