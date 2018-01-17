using System;
using System.Linq;
using Flarine.Core.Context;
using Flarine.Database;

namespace Flarine.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var loginCtx = ContextBase.GetInstance<LoginContext>())
            using (var dbCtx = DatabaseService.GetContext())
            {
                for (;;)
                {
                    foreach (var acc in dbCtx.Accounts.ToList())
                        Console.WriteLine(acc.Id);

                    Console.ReadLine();
                }
            }
        }
    }
}