using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Serialization
    {
        public static void SerializeToJson<T>(T obj, string filePath)
        {
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(filePath, json);
        }

        public static T DeserializeFromJson<T>(string filePath)
        {
            string json = File.ReadAllText(filePath);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
    }
}
