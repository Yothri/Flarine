﻿using Flarine.Core.Config;
using Flarine.Core.Context.Model;
using Flarine.Login.Context.Model;

namespace Flarine.Login.Config.Model
{
    internal sealed class LoginConfig : ContextConfiguration
    {
        public string DatabaseEngine { get; set; } = "MySql";
        public string WPDListenPrefix { get; set; } = "http://*:8010/auth/";
        public string ISCServerHost { get; set; } = "0.0.0.0";
        public int ISCServerPort { get; set; } = 8011;
        public Language DefaultLanguageId { get; set; } = Language.English;
        public SystemSetting[] SystemSettings { get; set; } = new SystemSetting[]
        {
            new SystemSetting { Name = "clientTextVersion", Value = "2018011501" },
            new SystemSetting { Name = "clientVersion", Value = "1.0.12" },
            new SystemSetting { Name = "isMaintenance", Value = "N" },
            new SystemSetting { Name = "assetBundleUrl", Value = "http://akamai.mobblo.com/EN/Live17/" },
            new SystemSetting { Name = "loggingYn", Value = "N" }
        };
        public GameServerGroup[] GameServerGroups { get; set; } = new GameServerGroup[] { new GameServerGroup() { GroupId = 1, Name = "Default", RecommendGameServerId = 1 } };
    }
}