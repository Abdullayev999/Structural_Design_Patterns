using JsonSaver;

namespace AdapterTask
{
    class JsonSaverAdapter : ISaver
    {
        private readonly JsonSave adaptee;
        public JsonSaverAdapter(JsonSave adaptee)
        {
            this.adaptee = adaptee;
        }
        public void Save<T>(T obj, string filename)
        {
            filename += ".json";
            adaptee.saveToJson(obj,filename);
        }
    }
}
