using Flarine.Login.Network.Web.Response;
using Flarine.Network.Web;

namespace Flarine.Login.Network.Web.Request
{
    internal sealed class NoticesRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            return new NoticesResponse
            {

            };
        }
    }
}