using System;
using Flarine.Core.Context;
using Flarine.Database;
using Flarine.Game.Network.ISC;
using Flarine.Game.Network.Photon;
using Flarine.Game.Network.Web;

namespace Flarine.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var gameCtx = ContextBase.GetInstance<GameContext>())
            using (var gameWPDListener = new WPDGameListener())
            using (var ISC = new ISCServer())
            using (var gameServer = new PhotonGameServer())
            using (DatabaseService.GetContext())
            using (var loginServerClient = new ISCClient())
            {
                gameCtx.AddService(gameServer);
                gameCtx.AddService(loginServerClient);

                gameWPDListener.StartListening();
                ISC.Start();
                gameServer.Start();
                gameCtx.SetStatus("Connecting to ISC...");
                loginServerClient.Connect();
                gameCtx.SetStatus("Listening");

                while (true)
                {
                    string inp = Console.ReadLine();
                    if (inp.Equals("exit"))
                        break;
                }

                loginServerClient.Disconnect();
                gameServer.Stop();
                ISC.Stop();
                gameWPDListener.StopListening();
            }
        }
    }
}