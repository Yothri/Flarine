using Flarine.Login.Context.Model;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Response
{
    internal sealed class SystemSettingsResponse : WPDResponse
    {
        [JsonProperty("systemSettings")]
        public SystemSetting[] SystemSettings { get; set; }
    }
}