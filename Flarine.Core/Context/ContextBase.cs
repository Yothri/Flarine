using System;
using System.Collections.Generic;
using System.IO;
using Flarine.Core.Config;
using Flarine.Core.Logging;
using Microsoft.Extensions.Logging;
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

        public ContextBase(string contextName)
        {
            ContextName = contextName;
            Services = new Dictionary<Type, object>();
            SetStatus("Initializing");
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

            Logger.Get<ContextBase>().LogInformation($"{file} has been loaded.");
            return JsonConvert.DeserializeObject<TConfig>(File.ReadAllText(file));
        }

        protected void SaveConfiguration<TConfig>(TConfig config, string file) where TConfig : ContextConfiguration, new()
        {
            var directory = Path.GetDirectoryName(file);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            Logger.Get<ContextBase>().LogInformation($"{file} has been saved.");
            File.WriteAllText(file, JsonConvert.SerializeObject(config, Formatting.Indented));
        }

        public void SetStatus(string status)
        {
            Console.Title = $"{ContextName} | Status: {status}";
        }

        public void AddService(Type type, object provider)
        {
            Services.Add(type, provider);
        }

        public void AddService<T>(T provider)
        {
            AddService(typeof(T), provider);
        }

        public void RemoveService(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            Services.Remove(type);
        }

        public object GetService(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            object service;
            if (Services.TryGetValue(type, out service))
                return service;

            return null;
        }

        public T GetService<T>() where T : class
        {
            var service = GetService(typeof(T));

            if (service == null)
                return null;

            return (T)service;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                SaveConfigurations();
            }
        }

        protected string ContextName { get; private set; }
        protected Dictionary<Type, object> Services { get; private set; }
    }
}