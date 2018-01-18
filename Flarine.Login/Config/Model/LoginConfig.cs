using Flarine.Core.Config;
using Flarine.Login.Context.Model;

namespace Flarine.Login.Config.Model
{
    internal sealed class LoginConfig : ContextConfiguration
    {
        public string DatabaseEngine { get; set; } = "SQLite";
        public string WPDListenPrefix { get; set; } = "http://*:8080/auth/";
        public Language DefaultLanguageId { get; set; } = Language.English;
    }
}