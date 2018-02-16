using System;
using Flarine.Core.Context;
using Flarine.Database;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Game.Network.Web
{
    internal abstract class GameWPDRequest : WPDRequest, IDisposable
    {
        public GameWPDRequest()
        {
            DataContext = DatabaseService.GetContext();
        }

        [JsonIgnore]
        protected GameContext GameContext { get => ContextBase.GetInstance<GameContext>(); }

        [JsonIgnore]
        protected DatabaseContext DataContext { get; }

        protected override void Dispose(bool disposing)
        {
            DataContext?.Dispose();
            base.Dispose(disposing);
        }
    }
}