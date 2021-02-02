using Newtonsoft.Json;
using System;
using System.IO;

namespace JsonSaver
{
    public class JsonSave
    {
        public void saveToJson<T>(T obj,string filename)
        {
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText( filename, json);
        }
    }
}
