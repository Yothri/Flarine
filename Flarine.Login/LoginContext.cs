using Flarine.Core.Context;
using Flarine.Database;
using Flarine.Login.Config.Model;
using Microsoft.EntityFrameworkCore;

namespace Flarine.Login
{
    internal sealed class LoginContext : ContextBase
    {
        public LoginContext()
        {
            DatabaseService.SetEngine(LoginConfig.DatabaseEngine);
            DatabaseService.GetContext().Database.Migrate();
        }

        public override void LoadConfigurations()
        {
            LoginConfig = LoadConfiguration<LoginConfig>("Config/LoginConfig.json");
        }

        public override void SaveConfigurations()
        {
            SaveConfiguration(LoginConfig, "Config/LoginConfig.json");
        }

        internal LoginConfig LoginConfig { get; private set; }
    }
}