using Newtonsoft.Json;

namespace Flarine.Gate.Config.Model
{
    public sealed class StageFarmVersion
    {
        [JsonProperty("farmId")]
        public int FarmId { get; set; } = 1;

        [JsonProperty("name")]
        public string Name { get; set; } = "Default";

        [JsonProperty("serverUrl")]
        public string ServerUrl { get; set; } = "http://*:80/auth/";
    }
}