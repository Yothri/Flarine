using System.Collections.Generic;
using Flarine.Core.Context;
using Flarine.Login.Context.Model;
using Flarine.Login.Network.Web.Response;
using Flarine.Network.Web;

namespace Flarine.Login.Network.Web.Request
{
    internal sealed class SupportedLanguagesRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            var supportedLanguages = new List<SupportedLanguage>();
            foreach (var clientText in ContextBase.GetInstance<LoginContext>().ClientTexts)
                supportedLanguages.Add(new SupportedLanguage { LanguageId = clientText.languageId, MaintenanceInfoUrl = string.Empty });

            return new SupportedLanguagesResponse
            {
                DefaultLanguageId = ContextBase.GetInstance<LoginContext>().LoginConfig.DefaultLanguageId,
                SupportedLanguages = supportedLanguages.ToArray()
            };
        }
    }
}