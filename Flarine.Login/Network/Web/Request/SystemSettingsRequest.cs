using Flarine.Login.Context.Model;
using Flarine.Login.Network.Web.Response;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Request
{
    internal sealed class SystemSettingsRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            return new SystemSettingsResponse
            {
                SystemSettings = new SystemSetting[]
                {
                    new SystemSetting{ Name = "clientTextVersion", Value = "2018011501" },
                    new SystemSetting { Name = "clientVersion", Value = "1.0.12" },
                    new SystemSetting { Name = "isMaintenance", Value = "N" },
                    //new SystemSetting { Name = "assetBundleUrl", Value = "http://akamai.mobblo.com/EN/Live17/" },
                }
            };
        }

        [JsonProperty("storeType")]
        public StoreType StoreType { get; set; }
    }
}