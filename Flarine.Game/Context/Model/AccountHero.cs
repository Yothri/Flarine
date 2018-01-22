using Flarine.Database.Entity;
using Newtonsoft.Json;

namespace Flarine.Game.Context.Model
{
    internal sealed class AccountHero
    {
        public AccountHero(Hero hero, string accountId)
        {
            AccountHeroId = hero.AccountHeroId;
            AccountId = accountId;
            HeroId = hero.HeroId;
            FaceId = hero.FaceId;
            Name = hero.Name;
            Level = hero.Level;
            Tradition = hero.Tradition;
            CostumeId = hero.CostumeId;
            CostumeVisible = hero.CostumeVisible;
            MountTier = hero.MountTier;
        }

        [JsonProperty("accountHeroId")]
        public int AccountHeroId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("heroId")]
        public int HeroId { get; set; }

        [JsonProperty("faceId")]
        public int FaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("tradition")]
        public int Tradition { get; set; }

        [JsonProperty("costumeId")]
        public int CostumeId { get; set; }

        [JsonProperty("costumeVisible")]
        public bool CostumeVisible { get; set; }

        [JsonProperty("mountTier")]
        public int MountTier { get; set; }
    }
}