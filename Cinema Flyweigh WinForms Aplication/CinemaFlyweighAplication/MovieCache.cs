using System.Collections.Generic;

namespace CinemaFlyweighAplication
{
    class MovieCache : ICache<string, Movie>
    {
        Dictionary<string, Movie> movies;
        public MovieCache()
        {
            movies = new Dictionary<string, Movie>();
        }
        public void AddValue(string key, Movie value)
        {
            movies.Add(key, value);
        }

        public Movie GetValue(string key)
        {
            if (movies.ContainsKey(key))
            {
                return movies[key];
            }
            return null;
        }
    }
}
