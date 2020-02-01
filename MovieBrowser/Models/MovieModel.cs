using System;
using System.Collections.Generic;

namespace MovieBrowser.Models
{
    public class MovieModel
    {
        public int id { get; set; }
        public int page { get; set; }
        public string iso_3166_1 { get; set; }
        public int total_results { get; set; }
        //public ObjectIds object_ids { get; set; }
        public long revenue { get; set; }
        public int total_pages { get; set; }
        public string name { get; set; }
        public bool @public { get; set; }
        //public Comments comments { get; set; }
        public string sort_by { get; set; }
        public string description { get; set; }
        public string backdrop_path { get; set; }
        public List<MovieObject> results { get; set; }
        public double average_rating { get; set; }
        public int runtime { get; set; }
        //public CreatedBy created_by { get; set; }
        public string poster_path { get; set; }
    }

    public class MovieObject
    {
        public string poster_path { get; set; }
        public double popularity { get; set; }
        public int vote_count { get; set; }
        public bool video { get; set; }
        public string media_type { get; set; }
        public int id { get; set; }
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public List<int> genre_ids { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
    }
}
