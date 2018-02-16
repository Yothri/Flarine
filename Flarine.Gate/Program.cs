using System;
using Flarine.Core.Context;
using Flarine.Gate.Network.Web;

namespace Flarine.Gate
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var loginCtx = ContextBase.GetInstance<GateContext>())
            using (var gateWPDListener = new WPDGateListener())
            {
                gateWPDListener.StartListening();
                loginCtx.SetStatus("Listening");

                while (true)
                {
                    string inp = Console.ReadLine();
                    if (inp.Equals("exit"))
                        break;
                }

                gateWPDListener.StopListening();
            }
        }
    }
}