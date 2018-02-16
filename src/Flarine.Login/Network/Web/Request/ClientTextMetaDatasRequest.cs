using System.Linq;
using Flarine.Core.Context;
using Flarine.Login.Context.Model;
using Flarine.Login.Network.Web.Response;
using Flarine.Network.Web;
using Newtonsoft.Json;

namespace Flarine.Login.Network.Web.Request
{
    internal sealed class ClientTextMetaDatasRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            var clientText = ContextBase.GetInstance<LoginContext>().ClientTexts.FirstOrDefault(t => t.languageId == (int)LanguageId);
            if (clientText == null)
                clientText = ContextBase.GetInstance<LoginContext>().ClientTexts.FirstOrDefault();
            if (clientText == null)
                return new ClientTextMetaDatasResponse() { Result = 1, ErrMsg = "Server has no languages loaded." };

            return new ClientTextMetaDatasResponse
            {
                ClientTexts = WPDUtil.ZipToBase64(clientText.SerializeBase64String())
            };
        }

        [JsonProperty("languageId")]
        public Language LanguageId { get; set; }
    }
}