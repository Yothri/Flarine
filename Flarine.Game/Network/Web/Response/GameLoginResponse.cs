using Flarine.Game.Context.Model;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Game.Network.Web.Response
{
    internal sealed class GameLoginResponse : WPDResponse
    {
        [JsonProperty("isMaintenance")]
        public bool IsMaintenance { get; set; }

        [JsonProperty("gameAccessToken")]
        public string GameAccessToken { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("lastAccountHeroId")]
        public int LastAccountHeroId { get; set; }

        [JsonProperty("serverTime")]
        public string ServerTime { get; set; }

        [JsonProperty("accountHeros")]
        public object AccountHeros { get; set; } = new object[] { };

        [JsonProperty("accountHeroEquipedGears")]
        public object AccountHeroEquippedGears { get; set; } = new object[] { };

        [JsonProperty("accountHeroBlocks")]
        public object AccountHeroBlocks { get; set; } = new object[] { };

        [JsonProperty("gameEnvSetting")]
        public GameEnvSetting GameEnvSetting { get; set; } = new GameEnvSetting { MetaDataVersion = 2019011914 };
    }
}