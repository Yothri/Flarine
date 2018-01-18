using System;
using Flarine.Core.Context;
using Flarine.Database;
using Flarine.Login.Network.Web;

namespace Flarine.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var loginCtx = ContextBase.GetInstance<LoginContext>())
            using (var loginWPDListener = new WPDLoginListener(loginCtx.LoginConfig.WPDListenPrefix))
            using (var dbCtx = DatabaseService.GetContext())
            {
                loginWPDListener.StartListening();

                while (true)
                {
                    string inp = Console.ReadLine();
                    if (inp.Equals("exit"))
                        break;
                }

                loginWPDListener.StopListening();
            }

            Console.ReadKey();
        }
    }
}