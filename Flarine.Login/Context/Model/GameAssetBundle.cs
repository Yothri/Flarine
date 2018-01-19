using Newtonsoft.Json;

namespace Flarine.Login.Context.Model
{
    internal class GameAssetBundle
    {
        [JsonProperty("bundleNo")]
        public int BundleNo { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("android_ver")]
        public int AndroidVersion { get; set; }

        [JsonProperty("ios_ver")]
        public int iOSVersion { get; set; }

        [JsonProperty("isCommon")]
        public bool IsCommon { get; set; }
    }
}