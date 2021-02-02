using System.IO;
using System.Xml.Serialization;

namespace Bridge_Pattern
{
    class XmlSaveLoader<T> : ISaveLoader<T> where T : class
    {
        public T Load(string filename)
        {
            filename += ".xml";
            var serializer = new XmlSerializer(typeof(T));
            using (var fileStream = new FileStream(filename, FileMode.Create))
            {
                var data = serializer.Deserialize(fileStream);
                return data as T;
            }
        }

        public void Save(T data, string filename)
        {
            filename += ".xml";
            var serializer = new XmlSerializer(typeof(T));
            using (var fileStream = new FileStream(filename, FileMode.Create))
            {
                serializer.Serialize(fileStream, data);
            }
        }
    }
}
