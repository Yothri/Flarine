using Flarine.Core.Config;

namespace Flarine.Login.Config.Model
{
    internal sealed class LoginConfig : ContextConfiguration
    {
        public string DatabaseEngine { get; set; } = "SQLite";
    }
}