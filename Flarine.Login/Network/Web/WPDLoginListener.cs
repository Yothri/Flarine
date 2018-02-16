﻿using System;
using System.Collections.Generic;
using Flarine.Core.Context;
using Flarine.Core.Logging;
using Flarine.Login.Network.Web.Request;
using Flarine.Network.Web;
using Microsoft.Extensions.Logging;

namespace Flarine.Login.Network.Web
{
    internal sealed class WPDLoginListener : WPDListener
    {
        public WPDLoginListener() : base(ContextBase.GetInstance<LoginContext>().LoginConfig.WPDListenPrefix)
        {

        }
        
        protected override void OnListenerStart()
        {
            Logger.Get<WPDLoginListener>().LogInformation("WPDLoginListener has been started.");
        }

        protected override void OnListenerStop()
        {
            Logger.Get<WPDLoginListener>().LogInformation("WPDLoginListener has been stopped.");
        }

        protected override Dictionary<string, Type> Handlers => new Dictionary<string, Type>
        {
            { "TrackingLocations", typeof(TrackingLocationsRequest) },
            { "SystemSettings", typeof(SystemSettingsRequest) },
            { "SupportedLanguages", typeof(SupportedLanguagesRequest) },
            { "ClientTextMetaDatas", typeof(ClientTextMetaDatasRequest) },
            { "IpCheck", typeof(IpCheckRequest) },
            { "GameServers", typeof(GameServersRequest) },
            { "CreateGuestUser", typeof(CreateGuestUserRequest) },
            { "Login", typeof(LoginRequest) },
            { "GameAssetBundles", typeof(GameAssetBundlesRequest) },
            { "Notices", typeof(NoticesRequest) },
            { "ImageResources", typeof(ImageResourcesRequest) }
        };

        protected override bool DecryptRequest => true;
    }
}