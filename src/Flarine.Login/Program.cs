﻿using System;
using Flarine.Core.Context;
using Flarine.Database;
using Flarine.Login.Network.ISC;
using Flarine.Login.Network.Web;

namespace Flarine.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var loginCtx = ContextBase.GetInstance<LoginContext>())
            using (var loginWPDListener = new WPDLoginListener())
            using (var ISC = new ISCServer())
            using (DatabaseService.GetContext())
            {
                loginCtx.AddService(ISC);

                loginWPDListener.StartListening();
                ISC.Start();
                loginCtx.SetStatus("Listening");

                while (true)
                {
                    string inp = Console.ReadLine();
                    if (inp.Equals("exit"))
                        break;
                }

                ISC.Stop();
                loginWPDListener.StopListening();
            }
        }
    }
}