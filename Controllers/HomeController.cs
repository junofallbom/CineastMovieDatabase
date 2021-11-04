using CineastMovieDatabase.Models;
using CineastMovieDatabase.Models.ViewModels;
using CineastMovieDatabase.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CineastMovieDatabase.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        private List<MovieDto> movieList;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                movieList = await repository.GetMovieList();
               // movieList.Sort((x, y) => y.cmdbRating.CompareTo(x.cmdbRating));
                var model = new HomeViewModel(movieList, null);
                return View(model);
            }
            catch (System.Exception)
            {
                var model = new HomeViewModel();
                ModelState.AddModelError(string.Empty, "Failed to connect to api");
                return View(model);
                throw;
            }
        }
    
        public async Task<ActionResult> SearchMovie(SearchMovieViewModel model)
        {
            var searchedMovie = await repository.SearchMovieByTitle(model.Query);
            if (searchedMovie.error != null)
            {
                movieList = await repository.GetMovieList();
                var errorModel = new HomeViewModel(movieList, searchedMovie.error);

                return View("~/Views/Home/Index.cshtml", errorModel);
            }
            else
            {
 var movie = await repository.GetMovie(searchedMovie.imdbID);

            MovieViewModel movieViewModel = null;
            if (movie == null)
            {
                 movieViewModel = new MovieViewModel(searchedMovie);
            }
            else
            {
                searchedMovie.numberOfLikes = movie.numberOfLikes;
                searchedMovie.numberOfDislikes = movie.numberOfDislikes;
                movieViewModel = new MovieViewModel(searchedMovie);
            }
            
            return View("~/Views/Movie/Index.cshtml", movieViewModel);
            }
           
        }
    }
}
