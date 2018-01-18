using Flarine.Core.Context;
using Flarine.Database;
using Flarine.Login.Config.Model;
using Microsoft.EntityFrameworkCore;

namespace Flarine.Login
{
    internal sealed class LoginContext : ContextBase
    {
        private const string CONFIG_PATH = "Config/LoginConfig.json";

        public LoginContext()
        {
            DatabaseService.SetEngine(LoginConfig.DatabaseEngine);
            DatabaseService.GetContext().Database.Migrate();
        }

        public override void LoadConfigurations()
        {
            LoginConfig = LoadConfiguration<LoginConfig>(CONFIG_PATH);
        }

        public override void SaveConfigurations()
        {
            SaveConfiguration(LoginConfig, CONFIG_PATH);
        }

        internal LoginConfig LoginConfig { get; private set; }
    }
}