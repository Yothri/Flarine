using Flarine.Core.Context;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Game.Network.Web
{
    internal abstract class GameWPDRequest : WPDRequest
    {
        [JsonIgnore]
        protected GameContext GameContext { get => ContextBase.GetInstance<GameContext>(); }
    }
}