using Newtonsoft.Json;

namespace Flarine.Network.Web
{
    public abstract class WPDRequest
    {
        public abstract WPDResponse Handle();

        [JsonProperty("cmd")]
        public string Cmd { get; set; }
    }
}