using Flarine.Tools.Views;
using Newtonsoft.Json;
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
            string bla = string.Empty;
            JsonConvert.DeserializeObject(bla);

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