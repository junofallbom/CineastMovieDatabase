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
        private MovieDto movie;
        private IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var movieList = await repository.GetMovie();
                movieList.Sort((x, y) => y.cmdbRating.CompareTo(x.cmdbRating));

                var model = new HomeViewModel(movieList);
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
    }
}
