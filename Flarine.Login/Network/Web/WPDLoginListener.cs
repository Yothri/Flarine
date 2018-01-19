using System;
using System.Collections.Generic;
using Flarine.Core.Context;
using Flarine.Core.Log;
using Flarine.Login.Network.Web.Request;
using Flarine.Network.Web;

namespace Flarine.Login.Network.Web
{
    internal sealed class WPDLoginListener : WPDListener
    {
        public WPDLoginListener() : base(ContextBase.GetInstance<LoginContext>().LoginConfig.WPDListenPrefix)
        {

        }
        
        protected override void OnListenerStart()
        {
            Logger.Log("WPDLoginListener has been started.");
        }

        protected override void OnListenerStop()
        {
            Logger.Log("WPDLoginListener has been stopped.");
        }

        protected override Dictionary<string, Type> Handlers => new Dictionary<string, Type>
        {
            { "TrackingLocations", typeof(TrackingLocationsRequest) },
            { "SystemSettings", typeof(SystemSettingsRequest) },
            { "SupportedLanguages", typeof(SupportedLanguagesRequest) },
            { "ClientTextMetaDatas", typeof(ClientTextMetaDatasRequest) },
            { "IpCheck", typeof(IpCheckRequest) }
        };

        protected override bool DecryptRequest => true;
    }
}