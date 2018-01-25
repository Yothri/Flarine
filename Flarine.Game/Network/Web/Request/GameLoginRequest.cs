using System;
using System.Collections.Generic;
using System.Linq;
using Flarine.Core.Context;
using Flarine.Core.Util;
using Flarine.Database;
using Flarine.Database.Entity;
using Flarine.Game.Context.Model;
using Flarine.Game.Network.Web.Response;
using Flarine.Network.Web;
using Microsoft.EntityFrameworkCore;
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
                    .Where(a => a.UserId == loginSession.User.UserId)
                    .Include(a => a.AccountHeros)
                    .FirstOrDefault();
            }

            if (account == null)
                return new GameLoginResponse { Result = 1 };

            var ctx = ContextBase.GetInstance<GameContext>();

            var gameAccessToken = new JObject();
            gameAccessToken["gameServerId"] = ctx.GameConfig.GameServerConfig.GameServerId;
            gameAccessToken["accountId"] = account.AccountGuid;
            gameAccessToken["accessSecret"] = Utils.RandomString(20);
            gameAccessToken["checkCode"] = Utils.RandomString(32);

            ctx.GameSessions.Add(new GameSession
            {
                User = loginSession.User,
                GameAccessToken = gameAccessToken.ToString()
            });

            List<AccountHero> accountHeros = new List<AccountHero>();
            foreach (var hero in account.AccountHeros)
            {
                accountHeros.Add(new AccountHero(hero, account.AccountGuid));
            }

            return new GameLoginResponse
            {
                IsMaintenance = ctx.GameConfig.GameServerConfig.IsMaintenance,
                GameAccessToken = gameAccessToken.ToString(),
                AccountId = account.AccountGuid,
                LastAccountHeroId = 0,
                ServerTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss zzz"),
                AccountHeros = accountHeros.ToArray()
            };
        }

        [JsonProperty("userAccessToken")]
        public string UserAccessToken { get; set; }

        [JsonProperty("virtualGameServerId")]
        public int VirtualGameServerId { get; set; }
    }
}