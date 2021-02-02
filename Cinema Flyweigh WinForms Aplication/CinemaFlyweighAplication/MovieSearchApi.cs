using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace CinemaFlyweighAplication
{
    public static class MovieSearchApi
    {
        static readonly string apiUrl = @"http://www.omdbapi.com/";
        static readonly string apiKey = "5b9b7798";

        static ICache<string, Movie> cache = new MovieCache();

        static public Movie Search(string title)
        {
            var movie = cache.GetValue(title);

            if (movie == null)
            {
                MessageBox.Show("Reading data from API...");

                var webClient = new WebClient();
                try
                {
                    var result = webClient.DownloadString($"{apiUrl}?apikey={apiKey}&t={title}");
                    dynamic data = JsonConvert.DeserializeObject<Movie>(result);
                    movie = new Movie()
                    {
                        Title = data.Title,
                        Year = data.Year,
                        Plot = data.Plot,
                        Actors = data.Actors,
                        Released = data.Released,
                        Runtime= data.Runtime
                    };

                    cache.AddValue(title, movie);
                }
                catch (Exception)
                {
                    MessageBox.Show("Not found!");
                }
            }
            else
            {
                MessageBox.Show("Reading data from cache...");
            }
            return movie;

        }
    }
}
