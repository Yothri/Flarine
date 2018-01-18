using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Flarine.Core.Log;
using Flarine.Gate.Network.Web.Request;
using Flarine.Network.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Flarine.Gate.Network.Web
{
    internal sealed class WPDGateListener : WPDListener
    {
        public WPDGateListener(string prefix) : base(prefix) { }

        protected override HttpListenerResponse HandleRequest(HttpListenerContext context)
        {
            var requestBody = default(string);
            using (var reader = new StreamReader(context.Request.InputStream))
                requestBody = reader.ReadToEnd();

            requestBody = WPDCryptography.Transform(requestBody, "D");
            var jsonObj = JObject.Parse(requestBody);

            var cmd = default(JToken);
            if (!jsonObj.TryGetValue("cmd", out cmd))
                throw new ArgumentException("requestBody");

            if (cmd.Type != JTokenType.String)
                throw new ArgumentException("cmd.Type");

            var sCmd = cmd.ToObject<string>();
            var type = default(Type);
            if (!Handlers.TryGetValue(sCmd, out type))
                Logger.Log($"Unhandled {sCmd}Request.", LogLevel.Warning);

            var request = JsonConvert.DeserializeObject(requestBody, type) as WPDRequest;

            using (var writer = new StreamWriter(context.Response.OutputStream))
                writer.Write(request.Handle().GetResponseBody());

            return context.Response;
        }

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