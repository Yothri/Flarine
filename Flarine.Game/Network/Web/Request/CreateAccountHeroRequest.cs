using System.Linq;
using Flarine.Database;
using Flarine.Database.Entity;
using Flarine.Game.Network.Web.Response;
using Flarine.Network.Web;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Flarine.Game.Network.Web.Request
{
    internal sealed class CreateAccountHeroRequest : GameWPDRequest
    {
        public override WPDResponse Handle()
        {
            var session = GameContext.GameSessions
                .Where(s => s.User.GameAccessToken == GameAccessToken).FirstOrDefault();

            if (session == null || !GameContext.GameDatas.heros.Any(h => h.heroId == HeroId) || !GameContext.GameDatas.faces.Any(f => f.faceId == FaceId))
                return new CreateAccountHeroResponse { Result = 1 };
            
            using (var dbContext = DatabaseService.GetContext())
            {
               if(dbContext.Heros.Any(h => h.Name == Name))
                    return new CreateAccountHeroResponse { Result = 102 };

                var account = dbContext.Accounts
                    .Where(a => a.UserId == session.User.UserId)
                    .Include(a => a.AccountHeros)
                    .FirstOrDefault();

                if (account == null)
                    return new CreateAccountHeroResponse { Result = 1 };

                var hero = new Hero
                {
                    ParentAccount = account,
                    HeroId = HeroId,
                    FaceId = FaceId,
                    CostumeId = 0,
                    CostumeVisible = true,
                    Level = 1,
                    Name = Name,
                    Tradition = 0,
                    MountTier = 0
                };
                account.AccountHeros.Add(hero);
                dbContext.SaveChanges();

                return new CreateAccountHeroResponse
                {
                    AccountHero = new
                    {
                        accountHeroId = account.AccountHeros.Where(h => h.Name == Name).FirstOrDefault().Id,
                        name = hero.Name,
                        faceId = hero.FaceId,
                        heroId = hero.HeroId,
                        level = hero.Level,
                        tradition = hero.Tradition
                    }
                };
            }
        }

        [JsonProperty("accessToken")]
        public string GameAccessToken { get; set; }

        [JsonProperty("heroId")]
        public int HeroId { get; set; }

        [JsonProperty("faceId")]
        public int FaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}