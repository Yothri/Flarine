using Flarine.Login.Context.Model;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Response
{
    internal sealed class GameAssetBundlesResponse : WPDResponse
    {
        [JsonProperty("gameAssetBundles")]
        public GameAssetBundle[] GameAssetBundles { get; set; }
    }
}