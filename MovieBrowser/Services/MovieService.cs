using System;
using System.Net.Http;
using System.Threading.Tasks;
using MovieBrowser.IService.IServices;
using MovieBrowser.Models;
using Newtonsoft.Json;

namespace MovieBrowser.Services
{
    public class MovieService : IMovieService
    {
        HttpClient _client;
        private string _apiKey = "976e01968799491aab0415d107b09781";

        public MovieService()
        {
            _client = new HttpClient();
        }

        public async Task<MovieModel> GetListOfMovies(int listId, string language = "en")
        {
            var uri = new Uri(string.Format(APIRoutes.GetMoviesList, listId)) + $"?api_key={_apiKey}&language={language}";
            //_client.. = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _apiKey);
            //_client.DefaultRequestHeaders.con
            MovieModel movies = new MovieModel();
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    movies = JsonConvert.DeserializeObject<MovieModel>(content);
                }
            }
            catch (Exception ex)
            {

            }
            return movies;
        }

    }
}
