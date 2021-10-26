using CineastMovieDatabase.Infrastructure;
using CineastMovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineastMovieDatabase.Repositories
{
    public class Repository : IRepository
    {
        private readonly IApiClient apiClient;
        private readonly string baseEndPoint = "https://grupp9.dsvkurs.miun.se/api";
        private readonly string baseEndPointImdb = " http://www.omdbapi.com/?i=tt3896198&apikey=296ed584";
        public Repository(IApiClient apiClient)
        {
            this.apiClient = apiClient;
        }
        public async Task<List<MovieDto>> GetMovie()
        {
            var result = await apiClient.GetAsync<List<MovieDto>>($"{baseEndPoint}/Movie");
            //var resultId = 
           
            return result;
        }

        //public async Task<List<MovieDto>> GetMovieFromImdb(var result)
        //{
        //    var id = 
        //    var result = await apiClient.GetAsync<List<MovieDto>>($"{baseEndPointImdb}/Movie");
        //    return result;
        //}
    }
}
