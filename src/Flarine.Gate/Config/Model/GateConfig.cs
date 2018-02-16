using Flarine.Core.Config;

namespace Flarine.Gate.Config.Model
{
    internal sealed class GateConfig : ContextConfiguration
    {
        public GateConfig()
        {
            StageFarmVersion = new StageFarmVersion();
        }

        public string WPDListenPrefix { get; set; } = "http://*:80/gate/";
        public StageFarmVersion StageFarmVersion { get; set; }
    }
}