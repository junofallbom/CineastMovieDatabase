using CineastMovieDatabase.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineastMovieDatabase.Models
{
    public class MovieDto
    {
        public string imdbID { get; set; }
        public int numberOfLikes { get; set; }
        public int numberOfDislikes { get; set; }
        public string plot { get; set; }
        public string title { get; set; }
        public string actors { get; set; }
        public List<RatingsDto> ratings { get; set; }
        public string poster { get; set; }
        public int cmdbRating { get; set; }

    }
}
