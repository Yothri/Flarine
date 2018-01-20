using System;
using System.Linq;
using Flarine.Core.Context;
using Flarine.Core.Util;
using Flarine.Database;
using Flarine.Database.Entity;
using Flarine.Game.Context.Model;
using Flarine.Game.Network.Web.Response;
using Flarine.Network.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Flarine.Game.Network.Web.Request
{
    internal sealed class GameLoginRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            var loginSession = ContextBase.GetInstance<GameContext>().LoginSessions.FirstOrDefault(s => s.User.AccessToken == UserAccessToken);
            if (loginSession == null)
                return new GameLoginResponse { Result = 1 };

            var account = default(Account);
            using (var dbCtx = DatabaseService.GetContext())
            {
                account = dbCtx.Accounts
                    .Where(a => a.UserId == loginSession.User.UserId).FirstOrDefault();
            }
            if (account == null)
                return new GameLoginResponse { Result = 1 };

            var ctx = ContextBase.GetInstance<GameContext>();

            var gameAccessToken = new JObject();
            gameAccessToken["gameServerId"] = ctx.GameConfig.GameServerConfig.GameServerId;
            gameAccessToken["accountId"] = account.AccountId;
            gameAccessToken["accessSecret"] = Utils.RandomString(20);
            gameAccessToken["checkCode"] = Utils.RandomString(32);

            ctx.GameSessions.Add(new GameSession
            {
                User = loginSession.User,
                GameAccessToken = gameAccessToken.ToString()
            });

            return new GameLoginResponse
            {
                IsMaintenance = ctx.GameConfig.GameServerConfig.IsMaintenance,
                GameAccessToken = gameAccessToken.ToString(),
                AccountId = account.AccountId,
                LastAccountHeroId = 0,
                ServerTime = DateTime.UtcNow.ToString()
            };
        }

        [JsonProperty("userAccessToken")]
        public string UserAccessToken { get; set; }

        [JsonProperty("virtualGameServerId")]
        public int VirtualGameServerId { get; set; }
    }
}