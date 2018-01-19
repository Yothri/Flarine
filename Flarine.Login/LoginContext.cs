using System;
using System.Collections.Generic;
using System.IO;
using Flarine.Core.Context;
using Flarine.Core.Context.Model;
using Flarine.Core.Log;
using Flarine.Database;
using Flarine.Login.Config.Model;
using Flarine.Login.Context.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebCommon;

namespace Flarine.Login
{
    internal sealed class LoginContext : ContextBase
    {
        private const string CONFIG_PATH = "Config/LoginConfig.json";
        private const string CLIENTTEXTS_PATH = "ClientTexts";

        public LoginContext() : base("LoginServer")
        {
            DatabaseService.SetEngine(LoginConfig.DatabaseEngine);
            DatabaseService.GetContext().Database.Migrate();

            GameServers = new List<GameServer>();
        }

        public override void LoadConfigurations()
        {
            LoginConfig = LoadConfiguration<LoginConfig>(CONFIG_PATH);
        }

        public override void LoadAssets()
        {
            ClientTexts = new List<WPDClientTexts>();
            if (!Directory.Exists(CLIENTTEXTS_PATH))
                Directory.CreateDirectory(CLIENTTEXTS_PATH);

            foreach (var file in Directory.GetFiles(CLIENTTEXTS_PATH, "*.json"))
            {
                var clientText = JsonConvert.DeserializeObject<WPDClientTexts>(File.ReadAllText(file));
                ClientTexts.Add(clientText);
                Logger.Log($"{Enum.GetName(typeof(Language), clientText.languageId)} - Language ({clientText.languageId}) has been loaded.");
            }

            if (ClientTexts.Count == 0)
                Logger.Log("ClientTexts not found. Provide at least one ClientText.", LogLevel.Fatal);
        }

        public override void SaveConfigurations()
        {
            SaveConfiguration(LoginConfig, CONFIG_PATH);
        }

        internal LoginConfig LoginConfig { get; private set; }
        internal List<WPDClientTexts> ClientTexts { get; private set; }
        internal List<GameServer> GameServers { get; set; }
    }
}