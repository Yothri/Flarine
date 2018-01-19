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
            {
                gameWPDListener.StartListening();
                ISC.Start();
                gameServer.Start();

                while (true)
                {
                    string inp = Console.ReadLine();
                    if (inp.Equals("exit"))
                        break;
                }

                gameServer.Stop();
                ISC.Stop();
                gameWPDListener.StopListening();
            }
        }
    }
}