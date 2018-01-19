using Flarine.Core.Util;
using Flarine.Database;
using Flarine.Database.Entity;
using Flarine.Login.Network.Web.Response;
using Flarine.Network.Web;

namespace Flarine.Login.Network.Web.Request
{
    internal sealed class CreateGuestUserRequest : WPDRequest
    {
        public override WPDResponse Handle()
        {
            var account = new Account
            {
                UserId = Utils.RandomString(10),
                UserSecret = Utils.RandomString(15)
            };

            using (var context = DatabaseService.GetContext())
            {
                context.Accounts.Add(account);
                context.SaveChanges();
            }

            return new CreateGuestUserResponse
            {
                UserId = account.UserId,
                UserSecret = account.UserSecret
            };
        }
    }
}