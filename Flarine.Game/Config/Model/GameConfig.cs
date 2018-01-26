using Flarine.Core.Config;
using Flarine.Core.Context.Model;

namespace Flarine.Game.Config.Model
{
    internal sealed class GameConfig : ContextConfiguration
    {
        public string WPDListenPrefix { get; set; } = "http://*:8020/game/";
        public string LoginISCHost { get; set; } = "192.168.0.122";
        public int LoginISCPort { get; set; } = 8011;
        public string ISCServerHost { get; set; } = "0.0.0.0";
        public int ISCServerPort { get; set; } = 8021;
        public string GameServerHost { get; set; } = "192.168.0.122";
        public int GameServerPort { get; set; } = 8022;
        public int MaxGameServerConnections { get; set; } = 500;
        public string DatabaseEngine { get; set; } = "MySql";
        public GameServer GameServerConfig { get; set; } = new GameServer();
    }
}