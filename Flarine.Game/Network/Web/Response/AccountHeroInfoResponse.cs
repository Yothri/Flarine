using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Game.Network.Web.Response
{
    internal sealed class AccountHeroInfoResponse : WPDResponse
    {
        [JsonProperty("accountHeroInfo")]
        public string AccountHeroInfo { get; set; }
    }
}