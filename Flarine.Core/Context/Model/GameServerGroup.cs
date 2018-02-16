using Newtonsoft.Json;

namespace Flarine.Core.Context.Model
{
    public sealed class GameServerGroup
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("recommendGameServerId")]
        public int RecommendGameServerId { get; set; }
    }
}