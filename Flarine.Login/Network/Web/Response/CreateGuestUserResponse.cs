using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Response
{
    internal sealed class CreateGuestUserResponse : WPDResponse
    {
        protected override bool EncryptResponse => true;

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userSecret")]
        public string UserSecret { get; set; }
    }
}