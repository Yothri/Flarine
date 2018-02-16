using System.IO;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Flarine.Database.Context
{
    internal sealed class MySQLContext : DatabaseContext
    {
        private const string CONFIG_FILE = "Config/MySQLConfiguration.json";

        public MySQLContext()
        {
            Configuration = new MySQLConfiguration();
            if (File.Exists(CONFIG_FILE))
                Configuration = JsonConvert.DeserializeObject<MySQLConfiguration>(File.ReadAllText(CONFIG_FILE));
            else
            {
                if (!Directory.Exists(Path.GetDirectoryName(CONFIG_FILE)))
                    Directory.CreateDirectory(Path.GetDirectoryName(CONFIG_FILE));

                File.WriteAllText(CONFIG_FILE, JsonConvert.SerializeObject((MySQLConfiguration)Configuration, Formatting.Indented));
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = (MySQLConfiguration)Configuration;
            optionsBuilder.UseMySql($"server={config.Server};userid={config.User};pwd={config.Password};port={config.Port};database={config.Database};sslmode=none;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}