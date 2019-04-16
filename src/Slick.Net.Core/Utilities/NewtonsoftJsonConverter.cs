using System;
using Slick.Net.Core.Utilities.Interfaces;
using Newtonsoft.Json;

namespace Slick.Net.Core.Utilities
{
    public class NewtonsoftJsonConverter : IJsonConverter
    {
        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public object Deserialize(string json)
        {
            return JsonConvert.DeserializeObject(json);
        }

        public object Deserialize(string json, Type type)
        {
            return JsonConvert.DeserializeObject(json, type);
        }

        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}