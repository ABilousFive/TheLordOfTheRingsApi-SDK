using System.Net;
using System.Net.Http.Json;
using TestProject.CustomExceptions;
using TestProject.Models;

namespace TestProject.Services
{
    public abstract class BaseService
    {
        private HttpClient _httpClient;
        private readonly string? _endpoint;
        protected string? Query;

        protected BaseService(HttpClient httpClient, string endpoint)
        {
            _endpoint = endpoint;

            _httpClient = httpClient;
            _httpClient.BaseAddress = new("https://the-one-api.dev/v2/");
        }

        protected async Task<Response<T>?> GetResponseAsync<T>(string additionalEndpoint = "") where T : class
        {
            var finalEndpoint = _endpoint + additionalEndpoint + Query;

            using var response = await _httpClient.GetAsync(finalEndpoint);
            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                    throw new NotAuthorizationException();

                throw new NotSuccessfulResponseException(response.StatusCode);
            }

            var a = await response.Content.ReadAsStringAsync();
            var responseObject = await response.Content.ReadFromJsonAsync<Response<T>>();
            if (responseObject is null)
                throw new InvalidResponseException();

            return responseObject;
        }
    }
}
