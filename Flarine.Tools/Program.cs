using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Flarine.Network.Web;
using Newtonsoft.Json;
using WebCommon;

namespace Flarine.Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(WPDUtil.Transform(Console.ReadLine(), "D"));
                Console.ReadLine();
            }

            //using (var stream = new FileStream(@"C:\Users\Johan\Desktop\ClientTexts.json", FileMode.Open))
            //{
            //    var formatter = new BinaryFormatter();

            //    WPDClientTexts b = new WPDClientTexts();
            //    b.DeserializeFromBase64String(formatter.Deserialize(stream) as string);

            //    File.WriteAllText(@"C:\Users\Johan\Desktop\unpacked.json", JsonConvert.SerializeObject(b, Formatting.Indented));
            //}

                
        }
    }
}