using System;
using System.IO;
using Flarine.Core.Config;
using Flarine.Core.Log;
using Newtonsoft.Json;

namespace Flarine.Core.Context
{
    public abstract class ContextBase : IDisposable
    {
        private static ContextBase instance;
        public static T GetInstance<T>() where T : ContextBase, new()
        {
            if (instance == null)
                instance = new T();
            return (T)instance;
        }

        public ContextBase()
        {
            LoadConfigurations();
            LoadAssets();
        }
        
        public abstract void LoadConfigurations();
        public abstract void SaveConfigurations();
        public abstract void LoadAssets();

        protected TConfig LoadConfiguration<TConfig>(string file) where TConfig : ContextConfiguration, new()
        {
            var directory = Path.GetDirectoryName(file);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (!File.Exists(file))
                return new TConfig();

            Logger.Log($"{file} has been loaded.");
            return JsonConvert.DeserializeObject<TConfig>(File.ReadAllText(file));
        }

        protected void SaveConfiguration<TConfig>(TConfig config, string file) where TConfig : ContextConfiguration, new()
        {
            var directory = Path.GetDirectoryName(file);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            Logger.Log($"{file} has been saved.");
            File.WriteAllText(file, JsonConvert.SerializeObject(config, Formatting.Indented));
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                SaveConfigurations();
            }
        }
    }
}