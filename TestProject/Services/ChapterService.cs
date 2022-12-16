using TestProject.Models;

namespace TestProject.Services
{
    public class ChapterService : BaseService
    {
        private const string ChapterBaseEndpoint = "/chapter";

        public ChapterService(HttpClient httpClient) : base(httpClient, ChapterBaseEndpoint)
        {
        }

        public async Task<Response<Chapter>> GetChapterAsync(QueryBuilder.QueryBuilder queryBuilder)
        {
            Query = queryBuilder.Build();
            return await GetResponseAsync<Chapter>();
        }

        public async Task<Response<Chapter>> GetChapterByIdAsync(string id, QueryBuilder.QueryBuilder queryBuilder)
        {
            Query = queryBuilder.Build();
            return await GetResponseAsync<Chapter>($"/{id}");
        }
    }
}
