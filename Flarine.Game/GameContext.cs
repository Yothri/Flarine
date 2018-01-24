using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using Flarine.Core.Context;
using Flarine.Core.Context.Model;
using Flarine.Core.Log;
using Flarine.Core.Network.Web;
using Flarine.Database;
using Flarine.Game.Config.Model;
using Flarine.Game.Context.Model;
using Flarine.Network.Web;
using Microsoft.EntityFrameworkCore;
using WebCommon;

namespace Flarine.Game
{
    internal sealed class GameContext : ContextBase
    {
        private const string CONFIG_PATH = "Config/GameConfig.json";
        private const string GAMEDATA_PATH = "Config/GameData";

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

        public async override void LoadAssets()
        {
            await Task.Factory.StartNew(() =>
            {
                if (!Directory.Exists(GAMEDATA_PATH))
                    Logger.Log($"GameData not found, please provide GameData in directory {GAMEDATA_PATH} first.", LogLevel.Fatal);
                else
                {
                    var startTime = Environment.TickCount;
                    GameDatas = GameDatas.FromPath(GAMEDATA_PATH);
                    CompressedGameDatas = WPDUtil.ZipToBase64(GameDatas.SerializeBase64String());
                    var timeDiff = Environment.TickCount - startTime;

                    Logger.Log($"GameData has been loaded in {timeDiff} ms.");
                }
            });
        }

        internal GameConfig GameConfig { get; private set; }
        internal WPDGameDatas GameDatas { get; private set; }
        internal string CompressedGameDatas { get; private set; }
        internal List<LoginSession> LoginSessions { get; private set; }
        internal ObservableCollection<GameSession> GameSessions { get; private set; }
    }
}