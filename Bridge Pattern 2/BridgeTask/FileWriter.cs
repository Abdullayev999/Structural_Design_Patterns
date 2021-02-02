using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BridgeTask
{
    class FileWriter : IWriter
    {
        public FileWriter(string path)
        {
            this.path = path;
        }
        public string path { get; set; }
        public void Write(List<string> list)
        {
           var json = JsonSerializer.Serialize(list);
           File.WriteAllText($"{path}.txt", json);
        }
    }
}
