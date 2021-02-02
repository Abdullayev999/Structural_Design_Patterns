using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using JsonSaver;
using XMLSaver;

namespace AdapterTask
{
    interface ISaver
    {
        public void Save<T>(T obj, string filename);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var saver = new List<ISaver>
            {
                new JsonSaverAdapter(new JsonSave()),
                new XMLSaverAdapter(new XMLSave())
            };

            foreach (var item in saver)
            {
                var tmp = new Person("Farid", "Abdullayev");
                item.Save(tmp, "text");
            }
        }
    }
}
