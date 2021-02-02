using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLSaver
{
    public class XMLSave
    {
        public void saveXmlFile<T>(string filename, T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (var fs = new FileStream(filename, FileMode.Create))
            {
                serializer.Serialize(fs, obj);
            }
        }
    }
}
