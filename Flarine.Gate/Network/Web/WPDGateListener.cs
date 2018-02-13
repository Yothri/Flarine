using System;
using System.Collections.Generic;
using Flarine.Core.Context;
using Flarine.Core.Logging;
using Flarine.Gate.Network.Web.Request;
using Flarine.Network.Web;
using Microsoft.Extensions.Logging;

namespace Flarine.Gate.Network.Web
{
    internal sealed class WPDGateListener : WPDListener
    {
        public WPDGateListener() : base(ContextBase.GetInstance<GateContext>().GateConfig.WPDListenPrefix) { }

        protected override void OnListenerStart()
        {
            Logger.Get<WPDGateListener>().LogInformation("WPDGateListener has been started.");
        }

        protected override void OnListenerStop()
        {
            Logger.Get<WPDGateListener>().LogInformation("WPDGateListener has been stopped.");
        }

        protected override Dictionary<string, Type> Handlers => new Dictionary<string, Type>
        {
            { "StageFarmVersion", typeof(StageFarmVersionRequest) }
        };
    }
}