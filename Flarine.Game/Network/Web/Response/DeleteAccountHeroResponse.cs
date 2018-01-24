using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Game.Network.Web.Response
{
    internal sealed class DeleteAccountHeroResponse : WPDResponse
    {
        [JsonProperty("deletedAccountHeroId")]
        public int DeletedAccountHeroId { get; set; }
    }
}