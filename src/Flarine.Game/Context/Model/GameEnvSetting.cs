using Newtonsoft.Json;

namespace Flarine.Game.Context.Model
{
    internal sealed class GameEnvSetting
    {
        [JsonProperty("metaDataVersion")]
        public int MetaDataVersion { get; set; }
    }
}