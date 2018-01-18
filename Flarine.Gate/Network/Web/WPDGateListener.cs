using System;
using System.Collections.Generic;
using Flarine.Core.Log;
using Flarine.Gate.Network.Web.Request;
using Flarine.Network.Web;

namespace Flarine.Gate.Network.Web
{
    internal sealed class WPDGateListener : WPDListener
    {
        public WPDGateListener(string prefix) : base(prefix) { }

        protected override void OnListenerStart()
        {
            Logger.Log("WPDGateListener has been started.");
        }

        protected override void OnListenerStop()
        {
            Logger.Log("WPDGateListener has been stopped.");
        }

        protected override Dictionary<string, Type> Handlers => new Dictionary<string, Type>
        {
            { "StageFarmVersion", typeof(StageFarmVersionRequest) }
        };
    }
}