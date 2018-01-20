using System.Collections.Generic;
using System.Collections.ObjectModel;
using Ether.Network;
using Flarine.Core.Context;
using Flarine.Core.Context.Model;
using Flarine.Database;
using Flarine.Game.Config.Model;
using Flarine.Game.Context.Model;
using Microsoft.EntityFrameworkCore;

namespace Flarine.Game
{
    internal sealed class GameContext : ContextBase
    {
        private const string CONFIG_PATH = "Config/GameConfig.json";

        public GameContext() : base("GameServer")
        {
            DatabaseService.SetEngine(GameConfig.DatabaseEngine);
            DatabaseService.GetContext().Database.Migrate();

            LoginSessions = new List<LoginSession>();
            GameSessions = new ObservableCollection<GameSession>();
        }

        public override void LoadConfigurations()
        {
            GameConfig = LoadConfiguration<GameConfig>(CONFIG_PATH);
        }

        public override void SaveConfigurations()
        {
            SaveConfiguration(GameConfig, CONFIG_PATH);
        }

        public override void LoadAssets() { }

        internal GameConfig GameConfig { get; private set; }
        internal List<LoginSession> LoginSessions { get; private set; }
        internal ObservableCollection<GameSession> GameSessions { get; private set; }
    }
}