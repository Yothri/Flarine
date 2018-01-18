using Flarine.Core.Context;
using Flarine.Gate.Network.Web.Response;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Gate.Network.Web.Request
{
    internal sealed class StageFarmVersionRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            return new StageFarmVersionResponse
            {
                StageFarmVersion = ContextBase.GetInstance<GateContext>().GateConfig.StageFarmVersion
            };
        }

        [JsonProperty("platformId")]
        public int PlatformId { get; set; }

        [JsonProperty("versionName")]
        public string VersionName { get; set; }

        [JsonProperty("buildNo")]
        public int BuildNo { get; set; }
    }
}