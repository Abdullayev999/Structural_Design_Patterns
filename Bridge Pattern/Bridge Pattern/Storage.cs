using System.Collections.Generic;

namespace Bridge_Pattern
{
    abstract class Storage<T> where T : class
    {
        protected ISaveLoader<List<T>> saveLoader;

        public Storage(ISaveLoader<List<T>> saveLoader)
        {
            this.saveLoader = saveLoader;
        }

        public abstract void Add(T item);
        public abstract void Save();
        public abstract void Load();
    }
}
