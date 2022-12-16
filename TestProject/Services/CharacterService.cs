using TestProject.Models;

namespace TestProject.Services
{
    public class CharacterService : BaseService
    {
        private const string CharacterBaseEndpoint = "/character";

        public CharacterService(HttpClient httpClient) : base(httpClient, CharacterBaseEndpoint)
        {
        }

        public async Task<Response<Character>> GetCharacterAsync(QueryBuilder.QueryBuilder queryBuilder)
        {
            Query = queryBuilder.Build();
            return await GetResponseAsync<Character>();
        }

        public async Task<Response<Character>> GetCharacterByIdAsync(string id, QueryBuilder.QueryBuilder queryBuilder)
        {
            Query = queryBuilder.Build();
            return await GetResponseAsync<Character>($"/{id}");
        }

        public async Task<Response<Quote>> GetQuoteByCharacterIdAsync(string id, QueryBuilder.QueryBuilder queryBuilder)
        {
            Query = queryBuilder.Build();
            return await GetResponseAsync<Quote>($"/{id}/quote");
        }
    }
}
