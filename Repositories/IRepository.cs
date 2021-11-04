using CineastMovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineastMovieDatabase.Repositories
{
    public interface IRepository
    {
        Task<List<MovieDto>> GetMovieList();
        Task<MovieDto> SearchMovieByTitle(string title);
        Task<MovieDto> GetMovie(string id);
        
    }
}
