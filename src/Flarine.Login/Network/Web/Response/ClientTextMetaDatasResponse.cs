using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Response
{
    internal sealed class ClientTextMetaDatasResponse : WPDResponse
    {
        [JsonProperty("clientTexts")]
        public string ClientTexts { get; set; }
    }
}