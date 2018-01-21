using System.Linq;
using Flarine.Core.Context;
using Flarine.Game.Network.Web.Response;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Game.Network.Web.Request
{
    internal sealed class GameMetaDatasRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            var session = ContextBase.GetInstance<GameContext>().GameSessions
                .Where(s => s.GameAccessToken == GameAccessToken).FirstOrDefault();

            if (session == null)
                return new GameMetaDatasResponse { Result = 1 };

            return new GameMetaDatasResponse
            {
                GameDatas = ContextBase.GetInstance<GameContext>().CompressedGameDatas
            };
        }

        [JsonProperty("accessToken")]
        public string GameAccessToken { get; set; }
    }
}