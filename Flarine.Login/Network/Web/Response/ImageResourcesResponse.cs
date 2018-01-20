using Flarine.Login.Context.Model;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Response
{
    internal sealed class ImageResourcesResponse : WPDResponse
    {
        [JsonProperty("imageResources")]
        public ImageResource[] ImageResources { get; set; }
    }
}