using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Game.Network.Web.Response
{
    internal sealed class CreateAccountHeroResponse : WPDResponse
    {
        [JsonProperty("accountHero")]
        public object AccountHero { get; set; }
    }
}