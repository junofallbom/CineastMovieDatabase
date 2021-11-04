using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineastMovieDatabase.Models.ViewModels
{
    public class MovieViewModel
    {
        public MovieDto SearchedMovie { get; set; }

        public MovieViewModel(MovieDto movie)
        {
            SearchedMovie = movie;
        }
    }
}
