using Newtonsoft.Json;

namespace Flarine.Login.Context.Model
{
    internal sealed class SupportedLanguage
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("maintenanceInfoUrl")]
        public string MaintenanceInfoUrl { get; set; }
    }
}