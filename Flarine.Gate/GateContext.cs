using Flarine.Core.Context;
using Flarine.Gate.Config.Model;

namespace Flarine.Gate
{
    internal sealed class GateContext : ContextBase
    {
        private const string CONFIG_PATH = "Config/GateConfig.json";

        public override void LoadConfigurations()
        {
            GateConfig = LoadConfiguration<GateConfig>(CONFIG_PATH);
        }

        public override void SaveConfigurations()
        {
            SaveConfiguration(GateConfig, CONFIG_PATH);
        }

        internal GateConfig GateConfig { get; private set; }
    }
}