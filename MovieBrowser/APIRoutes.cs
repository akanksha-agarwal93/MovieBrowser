using System;
namespace MovieBrowser
{
    public static class APIRoutes
    {
        public static string BaseServerURL = "https://api.themoviedb.org/3";
        public static string GetMoviesList = BaseServerURL + "/movie/popular";
        public static string GetIconImage = "https://image.tmdb.org/t/p/w200/{0}"; //image path for the selected movie
    }
}
