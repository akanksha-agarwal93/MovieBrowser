using System;
using System.Threading.Tasks;
using MovieBrowser.Models;

namespace MovieBrowser.IService.IServices
{
    public interface IMovieService
    {
        Task<MovieModel> GetListOfMovies(int listId, string language = "en");
    }
}
