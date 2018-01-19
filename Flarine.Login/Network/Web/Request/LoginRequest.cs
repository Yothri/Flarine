using System.Linq;
using Flarine.Core.Context;
using Flarine.Core.Context.Model;
using Flarine.Core.Util;
using Flarine.Database;
using Flarine.Database.Entity;
using Flarine.Login.Context.Model;
using Flarine.Login.Network.Web.Response;
using Flarine.Network.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Flarine.Login.Network.Web.Request
{
    internal sealed class LoginRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            var loginCtx = ContextBase.GetInstance<LoginContext>();

            var account = default(Account);
            using (var ctx = DatabaseService.GetContext())
            {
                account = ctx.Accounts
                    .FirstOrDefault(a => a.UserId == UserId && a.UserSecret == UserSecret);
            }

            if (account == null)
                return new LoginResponse { Result = 1 };

            var accessToken = new JObject();
            accessToken["userId"] = account.UserId;
            accessToken["accessSecret"] = Utils.RandomString(20);
            accessToken["checkCode"] = Utils.RandomString(32);
            accessToken["platform"] = "android";

            var user = new User
            {
                UserType = 1,
                UserId = account.UserId,
                UserSecret = account.UserSecret,
                AccessToken = accessToken.ToString(),
                LastVirtualGameServer = 0
            };

            var previousSession = loginCtx.Sessions.FirstOrDefault(s => s.User.UserId == user.UserId && s.User.UserSecret == user.UserSecret);
            if (previousSession != null)
                loginCtx.Sessions.Remove(previousSession);

            loginCtx.Sessions.Add(new LoginSession
            {
                User = user
            });

            return new LoginResponse
            {
                UserType = user.UserType,
                AccessToken = user.AccessToken,
                LastVirtualGameServerId = user.LastVirtualGameServer
            };
        }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userSecret")]
        public string UserSecret { get; set; }

        [JsonProperty("languageId")]
        public int LanguageId { get; set; }
    }
}