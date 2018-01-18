using Flarine.Core.Context;
using Flarine.Gate.Network.Web.Response;
using Flarine.Network.Web;

namespace Flarine.Gate.Network.Web.Request
{
    internal sealed class StageFarmVersionRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            return new StageFarmVersionResponse
            {
                StageFarmVersion = ContextBase.GetInstance<GateContext>().GateConfig.StageFarmVersion
            };
        }
    }
}