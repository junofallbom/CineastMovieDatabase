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
        public List<MovieDto> fullMovieList { get; set; }

        public string error { get; set; }

        public HomeViewModel(List<MovieDto> movieList, string errorMsg)
        {
            fullMovieList = movieList;
            error = errorMsg;
        }
        public HomeViewModel()
        {

        }
    }
}
