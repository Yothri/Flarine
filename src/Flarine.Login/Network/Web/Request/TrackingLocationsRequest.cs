using Flarine.Login.Network.Web.Response;
using Flarine.Network.Web;
using WebCommon;

namespace Flarine.Login.Network.Web.Request
{
    internal sealed class TrackingLocationsRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            var trackingLocations = new WPDTrackingLocations();
            trackingLocations.trackingLocations = new WPDTrackingLocation[] { };

            return new TrackingLocationsResponse
            {
                TrackingLocations = trackingLocations.SerializeBase64String()
            };
        }
    }
}