using CineastMovieDatabase.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineastMovieDatabase.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var movies = new List<MovieViewModel>
            {
                new MovieViewModel
                {
                    Title="Titanic",
                    cmdbRating=5
                },
                new MovieViewModel
                {
                    Title="The Godfather",
                    cmdbRating=4
                },
            };
            //ViewData["movies"] = movies;

            return View(movies);
        }
    }
}
