using TestProject.QueryBuilder;
using TestProject.Services;

namespace Debugger
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new("Bearer", "TsGMNDgBzAky6DtlSx6k");

            var bookService = new BookService(client);
            var queryBuilder = new QueryBuilder();
            queryBuilder
                .Match("name", "The Fellowship Of The Ring")
                .SetLimit(10);

            var response = await bookService.GetBooksAsync(queryBuilder);

            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}