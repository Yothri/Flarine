using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Response
{
    internal sealed class NoticesResponse : WPDResponse
    {
        [JsonProperty("notices")]
        public object Notices { get; set; } = new object[] { };
    }
}