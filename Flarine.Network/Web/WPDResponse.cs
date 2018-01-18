using Newtonsoft.Json;

namespace Flarine.Network.Web
{
    public abstract class WPDResponse
    {
        public string GetResponseBody()
        {
            var data = JsonConvert.SerializeObject(this);
            return EncryptResponse ? WPDCryptography.Transform(data, "E") : data;
        }

        [JsonProperty("result")]
        public int Result { get; set; }

        [JsonProperty("errMsg")]
        public string ErrMsg { get; set; }

        [JsonIgnore]
        protected virtual bool EncryptResponse { get => false; }
    }
}