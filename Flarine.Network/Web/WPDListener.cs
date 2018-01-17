using System;

namespace Flarine.Network.Web
{
    public abstract class WPDListener : IDisposable
    {
        public WPDListener()
        {

        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {

            }
        }

    }
}