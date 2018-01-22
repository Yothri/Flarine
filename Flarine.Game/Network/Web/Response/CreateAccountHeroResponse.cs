using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Game.Network.Web.Response
{
    internal sealed class CreateAccountHeroResponse : WPDResponse
    {
        [JsonProperty("accountHero")]
        public object AccountHero { get; set; }

        //[JsonProperty("accountHeroId")]
        //public int AccountHeroId { get; set; }

        //[JsonProperty("heroId")]
        //public int HeroId { get; set; }

        //[JsonProperty("faceId")]
        //public int FaceId { get; set; }

        //[JsonProperty("name")]
        //public string Name { get; set; }

        //[JsonProperty("tradition")]
        //public int Tradition { get; set; }
        
        //[JsonProperty("level")]
        //public int Level { get; set; }
    }
}