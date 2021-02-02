namespace CinemaFlyweighAplication
{
    interface ICache<Tkey,TValue>
    {
        TValue GetValue(Tkey key);
        void AddValue(Tkey key, TValue value);
    }
}
