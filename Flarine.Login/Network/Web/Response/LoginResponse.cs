using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Response
{
    internal sealed class LoginResponse : WPDResponse
    {
        protected override bool EncryptResponse => true;

        [JsonProperty("userType")]
        public int UserType { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("lastVirtualGameServerId")]
        public int LastVirtualGameServerId { get; set; }

        [JsonProperty("userGameServers")]
        public object UserGameServers { get; set; } = new object[] { };

        [JsonProperty("userGameServerLasts")]
        public object UserGameServerLasts { get; set; } = new object[] { };
    }
}