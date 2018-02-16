using Flarine.Tools.Views;
using System;
#if NET461
using System.Windows.Forms;
#endif

namespace Flarine.Tools
{
    class Program
    {
        static void Main(string[] args)
        {
#if NET461
            Application.EnableVisualStyles();
            Application.Run(new FrmResourceUnpacking());
#else
            Console.WriteLine("Not supported on .NET Core!");
#endif

            Console.ReadLine();
        }
    }
}