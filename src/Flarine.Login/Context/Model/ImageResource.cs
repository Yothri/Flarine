using Newtonsoft.Json;

namespace Flarine.Login.Context.Model
{
    internal sealed class ImageResource
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("imageId")]
        public int ImageId { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }
}