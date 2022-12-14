using TestProject.Models;

namespace TestProject.Services
{
    public class BookService : BaseService
    {
        private const string BookBaseEndpoint = "/book";

        public BookService(HttpClient client) : base(client, BookBaseEndpoint)
        { }
        
        public async Task<Response<Book>> GetBooksAsync(QueryBuilder.QueryBuilder queryBuilder)
        {
            Query = queryBuilder.Build();
            return await GetResponseAsync<Book>();
        }
        
        public async Task<Response<Book>> GetBookByIdAsync(string id)
        {
            return await GetResponseAsync<Book>($"/{id}");
        }
        
        public async Task<Response<Book>> GetChaptersByBookIdAsync(string id)
        {
            return await GetResponseAsync<Book>($"/{id}/chapter");
        }
    }
}
