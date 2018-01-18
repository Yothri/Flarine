using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Flarine.Login.Context.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StoreType
    {
       [EnumMember(Value = "playStore")]
       PlayStore
    }
}