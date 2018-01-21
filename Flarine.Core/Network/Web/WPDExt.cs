using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebCommon;

namespace Flarine.Core.Network.Web
{
    public static class WPDExt
    {
        public static WPDGameDatas FromPath(this WPDGameDatas datas, string path)
        {
            JObject obj = new JObject();
            foreach (var file in Directory.GetFiles(path, "*.json"))
            {
                dynamic subObj = JsonConvert.DeserializeObject(File.ReadAllText(file));
                obj[Path.GetFileNameWithoutExtension(file)] = subObj;
            }
            return obj.ToObject<WPDGameDatas>();
        }
    }
}