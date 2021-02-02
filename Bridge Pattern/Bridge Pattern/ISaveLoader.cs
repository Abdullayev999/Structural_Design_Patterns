namespace Bridge_Pattern
{
    interface ISaveLoader<T> where T : class
    {
        void Save(T data, string filename);
        T Load(string filename);
    }
}
