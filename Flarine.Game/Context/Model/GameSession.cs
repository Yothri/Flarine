using Ether.Network;
using Flarine.Core.Context.Model;

namespace Flarine.Game.Context.Model
{
    internal sealed class GameSession
    {
        public NetUser NetUser { get; set; }
        public User User { get; set; }
        public string GameAccessToken { get; set; }
        public int SelectedPlayCharacter { get; set; }
    }
}