using Flarine.Tools.Views;
using System;
#if NET461
using System.Windows.Forms;
#endif

namespace Flarine.Tools
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Available Tools: WPDTransforming, ResUnpack");
            var inp = "WPDTransforming"; //Console.ReadLine();
            if(inp.Equals("WPDTransforming"))
            {
#if NET461
                Application.EnableVisualStyles();
                Application.Run(new FrmWPDTransforming());
#else
                Console.WriteLine("Not supported on .NET Core!");
                Console.ReadLine();
#endif
            }
            else if(inp.Equals("ResUnpack"))
            {
#if NET461
                Application.EnableVisualStyles();
                Application.Run(new FrmResourceUnpacking());
#else
                Console.WriteLine("Not supported on .NET Core!");
                Console.ReadLine();
#endif
            }
        }
    }
}