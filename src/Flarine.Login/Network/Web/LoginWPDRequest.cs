using Flarine.Core.Context;
using Flarine.Network.Web;

namespace Flarine.Login.Network.Web
{
    internal abstract class LoginWPDRequest : WPDRequest
    {
        protected LoginContext LoginContext => ContextBase.GetInstance<LoginContext>();
    }
}