using Flarine.Core.Config;
using Flarine.Login.Context.Model;

namespace Flarine.Login.Config.Model
{
    internal sealed class LoginConfig : ContextConfiguration
    {
        public string DatabaseEngine { get; set; } = "SQLite";
        public string WPDListenPrefix { get; set; } = "http://*:8080/auth/";
        public string ISCServerHost { get; set; } = "192.168.0.122";
        public int ISCServerPort { get; set; } = 8011;
        public Language DefaultLanguageId { get; set; } = Language.English;
    }
}