using System.Threading.Tasks;

namespace CineastMovieDatabase.Infrastructure
{
    public interface IApiClient
    {
        Task<T> GetAsync<T>(string endpoint);
    }
}
