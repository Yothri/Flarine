using Newtonsoft.Json;

namespace Flarine.Login.Context.Model
{
    internal sealed class SystemSetting
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}