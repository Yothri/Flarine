using Flarine.Core.Context;
using Flarine.Login.Network.Web.Response;
using Flarine.Network.Web;

namespace Flarine.Login.Network.Web.Request
{
    internal sealed class GameAssetBundlesRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            return new GameAssetBundlesResponse
            {
                GameAssetBundles = ContextBase.GetInstance<LoginContext>().GameAssetBundles.ToArray()
            };
        }
    }
}