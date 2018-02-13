using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Flarine.Core.Logging;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
                try
                {
                    Listener.Start();
                    OnListenerStart();

                    Listener.BeginGetContext(new AsyncCallback(GetContextCallback), Listener);
                }
                catch(HttpListenerException ex)
                {
                    Logger.Get<WPDListener>().LogTrace(ex.ToString());
                }
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
                
                listener.BeginGetContext(new AsyncCallback(GetContextCallback), listener);
            }
            catch (HttpListenerException) { }

        }

        protected abstract void OnListenerStart();

        protected virtual HttpListenerResponse HandleRequest(HttpListenerContext context)
        {
            var requestBody = default(string);
            using (var reader = new StreamReader(context.Request.InputStream))
                requestBody = reader.ReadToEnd();

            if(DecryptRequest)
                requestBody = WPDUtil.Transform(requestBody, "D");

            var jsonObj = JObject.Parse(requestBody);

            var cmd = default(JToken);
            if (!jsonObj.TryGetValue("cmd", out cmd))
            {
                Logger.Get<WPDListener>().LogWarning("Invalid WPD-Request!");
                return BadRequest(context.Response);
            }

            if (cmd.Type != JTokenType.String)
            {
                Logger.Get<WPDListener>().LogWarning("Illegal JSON-Type!");
                return BadRequest(context.Response);
            }

            var sCmd = cmd.ToObject<string>();
            var type = default(Type);
            if (!Handlers.TryGetValue(sCmd, out type))
            {
                Logger.Get<WPDListener>().LogWarning($"Unhandled {sCmd}Request.");
                dynamic obj = JsonConvert.DeserializeObject(requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
                return BadRequest(context.Response);
            }

            using (var request = JsonConvert.DeserializeObject(requestBody, type) as WPDRequest)
            {
                using (var writer = new StreamWriter(context.Response.OutputStream))
                    writer.Write(request.Handle().GetResponseBody());
            }

            return context.Response;
        }

        private HttpListenerResponse BadRequest(HttpListenerResponse response)
        {
            response.StatusCode = 400;
            return response;
        }

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
        protected virtual bool DecryptRequest { get => false; }
    }
}