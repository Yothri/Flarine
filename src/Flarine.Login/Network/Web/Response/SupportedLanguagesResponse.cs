using Flarine.Login.Context.Model;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Response
{
    internal sealed class SupportedLanguagesResponse : WPDResponse
    {
        [JsonProperty("defaultLanguageId")]
        public Language DefaultLanguageId { get; set; }

        [JsonProperty("supportedLanguages")]
        public SupportedLanguage[] SupportedLanguages { get; set; }
    }
}