using Newtonsoft.Json;

namespace Flarine.Core.Context.Model
{
    public sealed class GameServer
    {
        [JsonProperty("virtualGameServerId")]
        public int VirtualGameServerId { get; set; } = 1;

        [JsonProperty("gameServerId")]
        public int GameServerId { get; set; } = 1;

        [JsonProperty("groupId")]
        public int GroupId { get; set; } = 1;

        [JsonProperty("displayNo")]
        public int DisplayNo { get; set; } = 1;

        [JsonProperty("name")]
        public string Name { get; set; } = "Default Game Server";

        [JsonProperty("apiUrl")]
        public string ApiUrl { get; set; } = "http://192.168.0.122:8020/game/";

        [JsonProperty("proxyGameServerIp")]
        public string ProxyGameServerIp { get; set; } = "192.168.0.122";

        [JsonProperty("proxyGameServerPort")]
        public int ProxyGameServerPort { get; set; } = 8022;

        [JsonProperty("isMaintenance")]
        public bool IsMaintenance { get; set; } = false;

        [JsonProperty("pkEnabled")]
        public bool PkEnabled { get; set; } = false;

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; } = "EU";

        [JsonProperty("stateCode")]
        public int StateCode { get; set; } = 1;

        [JsonProperty("isRecommend")]
        public bool IsRecommend { get; set; } = true;
    }
}