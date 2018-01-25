using System.Collections.Generic;
using Ether.Network;
using Flarine.Core.Context.Model;

namespace Flarine.Game.Context.Model
{
    internal sealed class GameSession
    {
        public NetUser Connection { get; set; }
        public User User { get; set; }
        public int SelectedPlayCharacter { get; set; }
        public List<Character> AccountHeros { get; set; } = new List<Character>();
    }
}