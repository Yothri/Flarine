using System.Linq;
using Flarine.Core.Context;
using Flarine.Login.Network.Web.Response;
using Flarine.Network.Web;

namespace Flarine.Login.Network.Web.Request
{
    internal sealed class GameServersRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            return new GameServersResponse
            {
                GameServerGroups = ContextBase.GetInstance<LoginContext>().LoginConfig.GameServerGroups,
                GameServers = ContextBase.GetInstance<LoginContext>().GameServers.Select(gs => gs.Value).ToArray()
            };
        }
    }
}