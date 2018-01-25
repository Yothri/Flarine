using System;
using System.Collections.Generic;
using System.Linq;
using Flarine.Core.Context;
using Flarine.Core.Util;
using Flarine.Game.Context.Model;
using Flarine.Game.Network.Web.Response;
using Flarine.Network.Web;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Flarine.Game.Network.Web.Request
{
    internal sealed class GameLoginRequest : GameWPDRequest
    {
        public override WPDResponse Handle()
        {
            var loginSession = ContextBase.GetInstance<GameContext>().LoginSessions.FirstOrDefault(s => s.User.UserAccessToken == UserAccessToken);
            if (loginSession == null)
                return new GameLoginResponse { Result = 1 };

            var account = DataContext.Accounts
                    .Where(a => a.UserId == loginSession.User.UserId)
                    .Include(a => a.AccountHeros)
                    .FirstOrDefault();

            if (account == null)
                return new GameLoginResponse { Result = 1 };

            var ctx = ContextBase.GetInstance<GameContext>();

            var gameAccessToken = new JObject();
            gameAccessToken["gameServerId"] = ctx.GameConfig.GameServerConfig.GameServerId;
            gameAccessToken["accountId"] = account.AccountGuid;
            gameAccessToken["accessSecret"] = Utils.RandomString(20);
            gameAccessToken["checkCode"] = Utils.RandomString(32);
            loginSession.User.GameAccessToken = gameAccessToken.ToString();

            ctx.GameSessions.Add(new GameSession
            {
                User = loginSession.User,
                AccountHeros = account.AccountHeros.Select(h => new Character(h, account.AccountGuid)).ToList()
            });

            List<object> accountHeros = new List<object>();
            foreach (var hero in account.AccountHeros)
            {
                accountHeros.Add(new
                {
                    accountId = account.AccountGuid,
                    accountHeroId = hero.Id,
                    heroId = hero.HeroId,
                    faceId = hero.FaceId,
                    name = hero.Name,
                    level = hero.Level,
                    tradition = hero.Tradition,
                    costumeId = hero.CostumeId,
                    costumeVisible = hero.CostumeVisible,
                    mountTier = hero.MountTier
                });
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