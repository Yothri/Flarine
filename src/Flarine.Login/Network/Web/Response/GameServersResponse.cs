using Flarine.Core.Context.Model;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Response
{
    internal sealed class GameServersResponse : WPDResponse
    {
        [JsonProperty("gameServerGroups")]
        public GameServerGroup[] GameServerGroups { get; set; }

        [JsonProperty("gameServers")]
        public GameServer[] GameServers { get; set; }
    }
}