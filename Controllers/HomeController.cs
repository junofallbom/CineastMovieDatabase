using CineastMovieDatabase.Models;
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
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var summary = repository.GetSummary();
            return View();
        }
    }
}
