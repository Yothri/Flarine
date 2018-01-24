using System.Linq;
using Flarine.Game.Network.Web.Response;
using Flarine.Network.Web;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Flarine.Game.Network.Web.Request
{
    internal sealed class DeleteAccountHeroRequest : GameWPDRequest
    {
        public override WPDResponse Handle()
        {
            var session = GameContext.GameSessions
                .Where(s => s.GameAccessToken == GameAccessToken)
                .FirstOrDefault();

            if (session == null) return new DeleteAccountHeroResponse { Result = 102 };

            var account = DataContext.Accounts
                .Where(a => a.UserId == session.User.UserId)
                .Include(a => a.AccountHeros)
                .FirstOrDefault();
            
            if (account == null) return new DeleteAccountHeroResponse { Result = 102 };

            var hero = account.AccountHeros
                .Where(h => h.Id == AccountHeroId)
                .FirstOrDefault();

            if(account.AccountHeros.RemoveAll(h => h.Id == AccountHeroId) == 1)
            {
                DataContext.Heros.Remove(hero);
                DataContext.SaveChanges();
            }

            return new DeleteAccountHeroResponse { DeletedAccountHeroId = AccountHeroId };
        }

        [JsonProperty("accessToken")]
        public string GameAccessToken { get; set; }

        [JsonProperty("accountHeroId")]
        public int AccountHeroId { get; set; }
    }
}