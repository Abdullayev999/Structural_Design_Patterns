using XMLSaver;

namespace AdapterTask
{
    class XMLSaverAdapter : ISaver
    {
        private readonly XMLSave adaptee;
        public XMLSaverAdapter(XMLSave adaptee)
        {
            this.adaptee = adaptee;
        }
        public void Save<T>(T obj, string filename)
        {
            filename += ".xml";
            adaptee.saveXmlFile(filename, obj);
        }
    }
}
