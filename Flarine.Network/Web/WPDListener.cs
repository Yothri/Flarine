using System;
using System.Collections.Generic;
using System.Net;

namespace Flarine.Network.Web
{
    public abstract class WPDListener : IDisposable
    {
        public WPDListener(string prefix)
        {
            Listener = new HttpListener();
            Listener.Prefixes.Add(prefix);
        }

        public void StartListening()
        {
            if(!Listener.IsListening)
            {
                Listener.Start();
                OnListenerStart();

                Listener.BeginGetContext(new AsyncCallback(GetContextCallback), Listener);
            }
        }

        public void StopListening()
        {
            if(Listener.IsListening)
            {
                Listener.Stop();
                OnListenerStop();
            }
        }

        private void GetContextCallback(IAsyncResult ar)
        {
            var listener = ar.AsyncState as HttpListener;

            try
            {
                HandleRequest(listener.EndGetContext(ar)).Close();
            }
            catch (HttpListenerException) { }
        }

        protected abstract void OnListenerStart();
        protected abstract HttpListenerResponse HandleRequest(HttpListenerContext context);
        protected abstract void OnListenerStop();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                Listener?.Stop();
            }
        }

        protected HttpListener Listener { get; private set; }
        protected abstract Dictionary<string, Type> Handlers { get; }
    }
}