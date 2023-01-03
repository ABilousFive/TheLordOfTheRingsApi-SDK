using TestPTheLordOfTHeRingsSDKroject.Services;
using TestTheLordOfTHeRingsSDKProject.Models;
using TheLordOfTHeRingsSDK.Models;

namespace TheLordOfTHeRingsSDK.Services
{
    public class MovieService : BaseService
    {
        private const string MovieBaseEndpoint = "/movie";

        public MovieService(HttpClient httpClient) : base(httpClient, MovieBaseEndpoint)
        {
        }

        public async Task<Response<Movie>> GetMovieAsync(QueryBuilder.QueryBuilder queryBuilder)
        {
            Query = queryBuilder.Build();
            return await GetResponseAsync<Movie>();
        }

        public async Task<Response<Movie>> GetBookByIdAsync(string id, QueryBuilder.QueryBuilder queryBuilder)
        {
            Query = queryBuilder.Build();
            return await GetResponseAsync<Movie>($"/{id}");
        }

        public async Task<Response<Quote>> GetQuoteByMovieIdAsync(string id, QueryBuilder.QueryBuilder queryBuilder)
        {
            Query = queryBuilder.Build();
            return await GetResponseAsync<Quote>($"/{id}/quote");
        }
    }
}
