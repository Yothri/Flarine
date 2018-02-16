using Flarine.Gate.Config.Model;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Gate.Network.Web.Response
{
    internal sealed class StageFarmVersionResponse : WPDResponse
    {
        [JsonProperty("stageFarmVersion")]
        public StageFarmVersion StageFarmVersion { get; set; }
    }
}