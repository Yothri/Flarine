using Flarine.Game.Network.Web.Response;
using Flarine.Network.Web;

namespace Flarine.Game.Network.Web.Request
{
    internal sealed class GameMetaDatasRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            return new GameMetaDatasResponse
            {

            };
        }
    }
}