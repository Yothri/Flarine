using Flarine.Core.Context;
using Flarine.Login.Network.Web.Response;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Request
{
    internal sealed class ImageResourcesRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            return new ImageResourcesResponse
            {
                ImageResources = ContextBase.GetInstance<LoginContext>().ImageResources.ToArray()
            };
        }

        [JsonProperty("languageId")]
        public int LanguageId { get; set; }
    }
}