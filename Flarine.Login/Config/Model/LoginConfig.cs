using Flarine.Core.Config;
using Flarine.Core.Context.Model;
using Flarine.Login.Context.Model;

namespace Flarine.Login.Config.Model
{
    internal sealed class LoginConfig : ContextConfiguration
    {
        public string DatabaseEngine { get; set; } = "SQLite";
        public string WPDListenPrefix { get; set; } = "http://*:8010/auth/";
        public string ISCServerHost { get; set; } = "192.168.0.122";
        public int ISCServerPort { get; set; } = 8011;
        public Language DefaultLanguageId { get; set; } = Language.English;
        public GameServerGroup[] GameServerGroups { get; set; } = new GameServerGroup[] { new GameServerGroup() { GroupId = 1, Name = "Default", RecommendGameServerId = 1 } };
    }
}