using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Ether.Network.Common;
using Flarine.Core.Context;
using Flarine.Core.Context.Model;
using Flarine.Core.Logging;
using Flarine.Database;
using Flarine.Login.Config.Model;
using Flarine.Login.Context.Model;
using Flarine.Network.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebCommon;

namespace Flarine.Login
{
    internal sealed class LoginContext : ContextBase
    {
        private const string CONFIG_PATH = "Config/LoginConfig.json";
        private const string CLIENTTEXTS_PATH = "Config/ClientTexts";
        private const string SYSTEMSETTINGS_PATH = "Config/SystemSettings.json";
        private const string BUNDLES_PATH = "Config/AssetBundles.json";
        private const string IMAGERES_PATH = "Config/ImageResources.json";

        public LoginContext() : base("LoginServer")
        {
            DatabaseService.SetEngine(LoginConfig.DatabaseEngine);

            try
            {
                DatabaseService.GetContext().Database.Migrate();
            }
            catch(Exception ex)
            {
                Logger.Get<LoginContext>().LogTrace(ex.ToString());
            }
            
            GameServers = new Dictionary<NetUser, GameServer>();
            Sessions = new ObservableCollection<LoginSession>();
            Sessions.CollectionChanged += Sessions_CollectionChanged;
        }

        public override void LoadConfigurations()
        {
            LoginConfig = LoadConfiguration<LoginConfig>(CONFIG_PATH);
        }

        public async override void LoadAssets()
        {
            if(LoginConfig.TryResolveOfficialData)
                await ResolveOfficialData();
            
            if(!LoginConfig.TryResolveOfficialData)
            {
                if(!File.Exists(SYSTEMSETTINGS_PATH))
                    Logger.Get<LoginContext>().LogCritical($"{SYSTEMSETTINGS_PATH} not found, provide it or turn on resolving official data.");
                else
                {
                    SystemSettings = JsonConvert.DeserializeObject<List<SystemSetting>>(File.ReadAllText(SYSTEMSETTINGS_PATH));
                }
            }
            else if(SystemSettings == null || SystemSettings.Count == 0)
                Logger.Get<LoginContext>().LogCritical("SystemSettings are not loaded, clients will be unable to connect.");

            Logger.Get<LoginContext>().LogInformation($"Loaded {SystemSettings.Count} SystemSettings.");

            #region "ClientTexts"
            if(!LoginConfig.TryResolveOfficialData)
            {
                ClientTexts = new List<WPDClientTexts>();
                if (!Directory.Exists(CLIENTTEXTS_PATH))
                    Directory.CreateDirectory(CLIENTTEXTS_PATH);

                foreach (var file in Directory.GetFiles(CLIENTTEXTS_PATH, "*.json"))
                {
                    var clientText = JsonConvert.DeserializeObject<WPDClientTexts>(File.ReadAllText(file));
                    ClientTexts.Add(clientText);
                    Logger.Get<LoginContext>().LogInformation($"{Enum.GetName(typeof(Language), clientText.languageId)} - Language ({clientText.languageId}) has been loaded.");
                }

                if (ClientTexts.Count == 0)
                    Logger.Get<LoginContext>().LogCritical("ClientTexts not found. Provide at least one ClientText.");
            }
            else if(ClientTexts == null)
                Logger.Get<LoginContext>().LogCritical("ClientTexts are not loaded, clients will be unable to connect.");

            Logger.Get<LoginContext>().LogInformation($"Loaded {ClientTexts.Count} ClientText(s).");
            #endregion


            #region "GameAssetBundles"
            if (!LoginConfig.TryResolveOfficialData)
            {
                if (!File.Exists(BUNDLES_PATH))
                    Logger.Get<LoginContext>().LogCritical("AssetBundles not found. Provide GameAssetBundles first.");
                else
                {
                    GameAssetBundles = JsonConvert.DeserializeObject<List<GameAssetBundle>>(File.ReadAllText(BUNDLES_PATH));
                }
            }
            else if(GameAssetBundles == null || GameAssetBundles.Count == 0)
                Logger.Get<LoginContext>().LogCritical("GameAssetBundles are not loaded, clients will be unable to connect.");

            Logger.Get<LoginContext>().LogInformation($"{GameAssetBundles.Count} AssetBundles have been loaded.");
            #endregion

            #region "Image Resources"
            if(!LoginConfig.TryResolveOfficialData)
            {
                if (!File.Exists(IMAGERES_PATH))
                    Logger.Get<LoginContext>().LogCritical("ImageResources not found. Provide ImageResources first.");
                else
                {
                    ImageResources = JsonConvert.DeserializeObject<List<ImageResource>>(File.ReadAllText(IMAGERES_PATH));
                }
            }
            else if(ImageResources == null)
                Logger.Get<LoginContext>().LogCritical("ImageResources are not loaded, clients will be unable to connect.");

            Logger.Get<LoginContext>().LogInformation($"{ImageResources.Count} ImageResources have been loaded.");
            #endregion
        }

        private async Task ResolveOfficialData()
        {
            using (var client = new HttpClient())
            {
                // clientTexts
                var cmd = new JObject();
                cmd["cmd"] = "ClientTextMetaDatas";
                cmd["languageId"] = JToken.FromObject(LoginConfig.DefaultLanguageId);
                var clientTexts = await client.PostAsync("http://auth-useu.flyff-legacy.com/Api.ashx",
                    new StringContent(WPDUtil.Transform(cmd.ToString(), "E")))
                    .Result.Content.ReadAsStringAsync();

                ClientTexts = new List<WPDClientTexts>();
                var clientTextsObj = JObject.Parse(clientTexts);
                var texts = new WPDClientTexts();
                texts.DeserializeFromBase64String(WPDUtil.UnZipFromBase64(clientTextsObj["clientTexts"].ToObject<string>()));
                ClientTexts.Add(texts);

                // systemSettings
                var systemSettings = await client.PostAsync("http://auth-useu.flyff-legacy.com/Api.ashx", 
                    new StringContent("iqj50z9l1no7FFb3DFDCptsx/V6fvA9IWAr0VTncFmssilWtIzfhMbj47ZPYgFUntCBb5rhQDw9Vm/YfciqWSQ=="))
                    .Result.Content.ReadAsStringAsync();

                var systemSettingsObj = JObject.Parse(systemSettings);
                SystemSettings = systemSettingsObj["systemSettings"].ToObject<List<SystemSetting>>();

                // gameAssetBundles
                var assetBundles = await client.PostAsync("http://auth-useu.flyff-legacy.com/Api.ashx",
                    new StringContent("ASLSWps5IKooLJRL3iSyy90lZ/rU9GA2OAtMxIRPymA="))
                    .Result.Content.ReadAsStringAsync();

                var assetBundlesObj = JObject.Parse(assetBundles);
                GameAssetBundles = assetBundlesObj["gameAssetBundles"].ToObject<List<GameAssetBundle>>();

                // imageResources
                var imageResources = await client.PostAsync("http://auth-useu.flyff-legacy.com/Api.ashx",
                    new StringContent("MsyFTWwwCoXatcd94okYZXz96tp5wnj4u7RfXjYUR9civXXRkEiJtJ7PrssWIN18"))
                    .Result.Content.ReadAsStringAsync();

                var imageResourcesObj = JObject.Parse(imageResources);
                ImageResources = imageResourcesObj["imageResources"].ToObject<List<ImageResource>>();
            }
        }

        public override void SaveConfigurations()
        {
            SaveConfiguration(LoginConfig, CONFIG_PATH);
        }

        private void Sessions_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (LoginSession itm in e.NewItems)
                    Logger.Get<LoginContext>().LogInformation($"User {itm.User.UserId} logged in.");
            }
            if(e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (LoginSession itm in e.OldItems)
                    Logger.Get<LoginContext>().LogInformation($"User {itm.User.UserId} logged out.");
            }
        }

        internal LoginConfig LoginConfig { get; private set; }
        internal List<WPDClientTexts> ClientTexts { get; private set; }
        internal Dictionary<NetUser, GameServer> GameServers { get; set; }
        internal ObservableCollection<LoginSession> Sessions { get; private set; }
        internal List<SystemSetting> SystemSettings { get; private set; }
        internal List<GameAssetBundle> GameAssetBundles { get; private set; }
        internal List<ImageResource> ImageResources { get; private set; }
    }
}