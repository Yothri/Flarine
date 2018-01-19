using System;
using System.Collections.Generic;
using Flarine.Core.Context;
using Flarine.Core.Log;
using Flarine.Network.Web;

namespace Flarine.Game.Network.Web
{
    internal sealed class WPDGameListener : WPDListener
    {
        public WPDGameListener() : base(ContextBase.GetInstance<GameContext>().GameConfig.WPDListenPrefix)
        {

        }

        protected override void OnListenerStart()
        {
            Logger.Log("WPDGameListener has been started.");
        }

        protected override void OnListenerStop()
        {
            Logger.Log("WPDGameListener has been stopped.");
        }

        protected override Dictionary<string, Type> Handlers => new Dictionary<string, Type>
        {
           
        };

        protected override bool DecryptRequest => true;
    }
}