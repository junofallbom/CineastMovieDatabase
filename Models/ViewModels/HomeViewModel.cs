using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CineastMovieDatabase.Models.ViewModels
{
    public class HomeViewModel
    {
        //[DisplayFormat(DataFormatString ="{0:N0}")]
        //[DisplayName("Movie id IMDB")]

        public List<MovieDto> fullMovieList { get; set; }

        public HomeViewModel(List<MovieDto> movieList)
        {
            fullMovieList = movieList;

        }
        public HomeViewModel()
        {

        }
    }
}
