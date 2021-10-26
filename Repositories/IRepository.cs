using CineastMovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineastMovieDatabase.Repositories
{
    public interface IRepository
    {
        /// <summary>
        /// Retrieves a summary of movies
        /// </summary>
        /// <returns></returns>

        Task<List<MovieDto>> GetMovie();
        //Task<MovieDto> GetMovie();
    }
}
