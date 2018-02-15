using Flarine.Tools.Views;
using System;
using System.Windows.Forms;

namespace Flarine.Tools
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            Application.Run(new FrmDecodeAsset());
        }
    }
}