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
        private readonly string baseEndPointImdb = "http://www.omdbapi.com/?apikey=296ed584";

        public Repository(IApiClient apiClient)
        {
            this.apiClient = apiClient;
        }
        
        public async Task<MovieDto> SearchMovieByTitle(string title) => await apiClient.GetAsync<MovieDto>($"{baseEndPointImdb}&t={title}&plot=full");

        public async Task<MovieDto> GetMovie(string id) => await apiClient.GetAsync<MovieDto>($"{baseEndPoint}/Movie/{id}");

        public async Task<List<MovieDto>> GetMovieList()
        {
            var top3Movies = "/Toplist?sort=desc&count=3&type=ratings";
            var movieList = await apiClient.GetAsync<List<MovieDto>>($"{baseEndPoint}{top3Movies}");
            await Task.WhenAll(movieList.Select(movie => DoAsync(movie)));
            return movieList;
        }

        private async Task<MovieDto> DoAsync(MovieDto movie)
        {
            var result = await apiClient.GetAsync<MovieDto>($"http://www.omdbapi.com/?i=" + movie.imdbID + "&apikey=296ed584&plot=full");
            movie.plot = result.plot;
            movie.title = result.title;
            movie.actors = result.actors;
            movie.poster = result.poster;
            movie.ratings = result.ratings;
            movie.cmdbRating = movie.numberOfLikes - movie.numberOfDislikes;
            return movie;
        }


    }
}

