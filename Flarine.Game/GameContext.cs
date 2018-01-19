using Flarine.Core.Context;
using Flarine.Database;
using Flarine.Game.Config.Model;
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
    }
}