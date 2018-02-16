using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Game.Network.Web.Response
{
    internal sealed class GameMetaDatasResponse : WPDResponse
    {
        [JsonProperty("gameDatas")]
        public string GameDatas { get; set; }
    }
}