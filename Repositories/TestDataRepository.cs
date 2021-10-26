using CineastMovieDatabase.Infrastructure;
using CineastMovieDatabase.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CineastMovieDatabase.Repositories
{
    public class TestDataRepository : IRepository
    {
        private readonly IApiClient apiClient;
        private readonly string basePath;
        private readonly string baseEndPointImdb = "http://www.omdbapi.com/?i=";
        private readonly string searchEndPointImdb = "http://www.omdbapi.com/?t=";

        public TestDataRepository(IWebHostEnvironment environment, IApiClient apiClient)
        {
            basePath = $@"{environment.ContentRootPath}\TestData\";
            this.apiClient = apiClient;
        }
     
        public async Task<List<MovieDto>> GetMovie()
        {
            await Task.Delay(0);
            var movieList = GetTestData<List<MovieDto>>("cmdbMovies.json");

            foreach (var movie in movieList)
            {
                var result = await apiClient.GetAsync<MovieDto>($"http://www.omdbapi.com/?i="+movie.imdbID+"&apikey=296ed584");
                movie.plot = result.plot;
                movie.title = result.title;
                movie.actors = result.actors;
                movie.poster = result.poster;
                movie.ratings = result.ratings;
                movie.cmdbRating = movie.numberOfLikes - movie.numberOfDislikes;
            }
            return movieList;
        }

        private T GetTestData<T>(string testfile)
        {
            var path = $"{basePath}{testfile}";
            string data = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(data);
        }

        //public async Task<List<MovieDto>> SearchMovie()
        //{
        //    await Task.Delay(0);
        //    var searchedMovieId = 
        //    var search = await apiClient.GetAsync<MovieDto>($"http://www.omdbapi.com/?i=" + movie.imdbID + "&apikey=296ed584");
        //        movie.plot = result.plot;
        //        movie.title = result.title;
        //        movie.actors = result.actors;
        //        movie.poster = result.poster;
        //        movie.ratings = result.ratings;
        //        movie.cmdbRating = movie.numberOfLikes - movie.numberOfDislikes;
            
        //    return search;
        //}
    }
}
