using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Flarine.Core.Util;
using Flarine.Network.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebCommon;

namespace Flarine.Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine(WPDUtil.Transform("MsyFTWwwCoXatcd94okYZXz96tp5wnj4u7RfXjYUR9fKPsJ76hDYOxwP3S+e1o4E", "D"));
            //    Console.ReadLine();
            //}

            //var bla = File.ReadAllText(@"C:\users\Johan\Desktop\gamedatas.txt"); 
            //    var unzipped = WPDUtil.UnZipFromBase64(bla);

            //WPDGameDatas datas = new WPDGameDatas();
            //datas.DeserializeFromBase64String(unzipped);

            //File.WriteAllText(@"C:\Users\Johan\Desktop\GameDatas.json", JsonConvert.SerializeObject(datas, Formatting.Indented));

            //var obj = JObject.Parse(File.ReadAllText(@"C:\Users\Johan\Desktop\GameDatas.json"));

            //var path = @"C:\Users\Johan\Desktop\GameDatas";

            //var gameDatas = LoadGameDatasFromDisk(path);

            //var data = @"C:\Users\Johan\Desktop\accountheroinfo.txt";
            //WPDAccountHeroInfo info = new WPDAccountHeroInfo();
            //info.DeserializeFromBase64String(File.ReadAllText(data));

            //var bla =JsonConvert.SerializeObject(info, Formatting.Indented);
            //File.WriteAllText(@"C:\Users\johan\desktop\test.json", bla);

            //if (!Directory.Exists(path))
            //    Directory.CreateDirectory(path);

            //foreach (var tkn in obj)
            //{
            //    File.WriteAllText(Path.Combine(path, $"{tkn.Key}.json"), tkn.Value.ToString());
            //}

            //using (var stream = new FileStream(@"C:\Users\Johan\Desktop\ClientTexts.json", FileMode.Open))
            //{
            //    var formatter = new BinaryFormatter();

            //    WPDClientTexts b = new WPDClientTexts();
            //    b.DeserializeFromBase64String(formatter.Deserialize(stream) as string);

            //    File.WriteAllText(@"C:\Users\Johan\Desktop\unpacked.json", JsonConvert.SerializeObject(b, Formatting.Indented));
            //}


        }

        static WPDGameDatas LoadGameDatasFromDisk(string path)
        {
            JObject obj = new JObject();
            foreach(var file in Directory.GetFiles(path, "*.json"))
            {
                dynamic subObj = JsonConvert.DeserializeObject(File.ReadAllText(file));
                obj[Path.GetFileNameWithoutExtension(file)] = subObj;
            }
            return obj.ToObject<WPDGameDatas>();
        }
    }
}