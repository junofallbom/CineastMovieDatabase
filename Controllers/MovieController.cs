using CineastMovieDatabase.Models;
using CineastMovieDatabase.Models.ViewModels;
using CineastMovieDatabase.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineastMovieDatabase.Controllers
{
    public class MovieController : Controller
    {
        private MovieDto movie;
        private IRepository repository;

        public MovieController(IRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> LikeMovie(SearchMovieViewModel model)
        {
            //var likedMovie = await repository.LikeMovie();
            //MovieViewModel movieViewModel = new MovieViewModel(likedMovie);
            //return View("~/Views/Movie/Index.cshtml", movieViewModel);
            return null;
        }


    }
}
