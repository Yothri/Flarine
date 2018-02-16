using System.Collections.Generic;
using Flarine.Core.Context.Model;
using Flarine.Game.Network.Photon.Common;

namespace Flarine.Game.Context.Model
{
    internal sealed class GameSession
    {
        public PhotonGameConnection Connection { get; set; }
        public User User { get; set; }
        public int SelectedPlayCharacter { get; set; }
        public List<Character> AccountHeros { get; set; } = new List<Character>();
    }
}