using System.IO;
using System.Text.Json;

namespace Bridge_Pattern
{
    class JsonSaveLoader<T> : ISaveLoader<T> where T : class
    {
        public T Load(string filename)
        {
            filename += ".json";
            var json = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<T>(json);
        }

        public void Save(T data, string filename)
        {
            filename += ".json";
            var json = JsonSerializer.Serialize(data);
            File.WriteAllText(filename, json);
        }
    }
}
