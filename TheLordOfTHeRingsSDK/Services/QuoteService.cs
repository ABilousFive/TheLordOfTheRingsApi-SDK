using TestPTheLordOfTHeRingsSDKroject.Services;
using TheLordOfTHeRingsSDK.Models;

namespace TheLordOfTHeRingsSDK.Services
{
    public class QuoteService : BaseService
    {
        private const string QuoteBaseEndpoint = "/quote";

        public QuoteService(HttpClient httpClient) : base(httpClient, QuoteBaseEndpoint)
        {
        }

        public async Task<Response<Quote>> GetQuoteAsync(QueryBuilder.QueryBuilder queryBuilder)
        {
            Query = queryBuilder.Build();
            return await GetResponseAsync<Quote>();
        }

        public async Task<Response<Quote>> GetQuoteByIdAsync(string id, QueryBuilder.QueryBuilder queryBuilder)
        {
            Query = queryBuilder.Build();
            return await GetResponseAsync<Quote>($"/{id}");
        }
    }
}
