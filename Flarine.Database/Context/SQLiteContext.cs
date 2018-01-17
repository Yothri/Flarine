using System.IO;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Flarine.Database.Context
{
    internal sealed class SQLiteContext : DatabaseContext
    {
        private const string CONFIG_FILE = "Config/SQLiteConfiguration.json";

        public SQLiteContext()
        {
            Configuration = new SQLiteConfiguration();
            if (File.Exists(CONFIG_FILE))
                Configuration = JsonConvert.DeserializeObject<SQLiteConfiguration>(File.ReadAllText(CONFIG_FILE));
            else
            {
                if (!Directory.Exists(Path.GetDirectoryName(CONFIG_FILE)))
                    Directory.CreateDirectory(Path.GetDirectoryName(CONFIG_FILE));

                File.WriteAllText(CONFIG_FILE, JsonConvert.SerializeObject((SQLiteConfiguration)Configuration, Formatting.Indented));
            }

            var directory = Path.GetDirectoryName(((SQLiteConfiguration)Configuration).DatabaseFile);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = (SQLiteConfiguration)Configuration;

            optionsBuilder.UseSqlite(string.Format("Data Source={0}", config.DatabaseFile));
            base.OnConfiguring(optionsBuilder);
        }
    }
}