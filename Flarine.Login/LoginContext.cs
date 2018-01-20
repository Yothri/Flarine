using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using Ether.Network;
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
        private const string BUNDLES_PATH = "Config/AssetBundles.json";
        private const string IMAGERES_PATH = "Config/ImageResources.json";

        public LoginContext() : base("LoginServer")
        {
            DatabaseService.SetEngine(LoginConfig.DatabaseEngine);
            DatabaseService.GetContext().Database.Migrate();
            
            GameServers = new Dictionary<NetUser, GameServer>();
            Sessions = new ObservableCollection<LoginSession>();
            Sessions.CollectionChanged += Sessions_CollectionChanged;
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

            GameAssetBundles = new List<GameAssetBundle>();
            if (!File.Exists(BUNDLES_PATH))
                Logger.Log("AssetBundles not found. Provide GameAssetBundles first.", LogLevel.Fatal);
            else
            {
                GameAssetBundles = JsonConvert.DeserializeObject<List<GameAssetBundle>>(File.ReadAllText(BUNDLES_PATH));
                Logger.Log($"{GameAssetBundles.Count} AssetBundles have been loaded.");
            }

            ImageResources = new List<ImageResource>();
            if (!File.Exists(IMAGERES_PATH))
                Logger.Log("ImageResources not found. Provide ImageResources first.", LogLevel.Fatal);
            else
            {
                ImageResources = JsonConvert.DeserializeObject<List<ImageResource>>(File.ReadAllText(IMAGERES_PATH));
                Logger.Log($"{ImageResources.Count} ImageResources have been loaded.");
            }
        }

        public override void SaveConfigurations()
        {
            SaveConfiguration(LoginConfig, CONFIG_PATH);
        }

        private void Sessions_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (LoginSession itm in e.NewItems)
                    Logger.Log($"User {itm.User.UserId} logged in.");
            }
            if(e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (LoginSession itm in e.OldItems)
                    Logger.Log($"User {itm.User.UserId} logged out.");
            }
        }

        internal LoginConfig LoginConfig { get; private set; }
        internal List<WPDClientTexts> ClientTexts { get; private set; }
        internal Dictionary<NetUser, GameServer> GameServers { get; set; }
        internal ObservableCollection<LoginSession> Sessions { get; private set; }
        internal List<GameAssetBundle> GameAssetBundles { get; private set; }
        internal List<ImageResource> ImageResources { get; private set; }
    }
}