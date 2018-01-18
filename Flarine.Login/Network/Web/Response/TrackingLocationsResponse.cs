using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Response
{
    internal sealed class TrackingLocationsResponse : WPDResponse
    {
        [JsonProperty("trackingLocations")]
        public string TrackingLocations { get; set; }
    }
}