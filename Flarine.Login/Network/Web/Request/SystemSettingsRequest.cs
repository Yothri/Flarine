using Flarine.Login.Context.Model;
using Flarine.Login.Network.Web.Response;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Request
{
    internal sealed class SystemSettingsRequest : LoginWPDRequest
    {
        public override WPDResponse Handle()
        {
            return new SystemSettingsResponse
            {
                SystemSettings = LoginContext.LoginConfig.SystemSettings.ToArray()
            };
        }

        [JsonProperty("storeType")]
        public StoreType StoreType { get; set; }
    }
}