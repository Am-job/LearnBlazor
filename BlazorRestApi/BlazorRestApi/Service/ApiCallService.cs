using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;
namespace BlazorRestApi.Service
{
    public class ApiCallService
    {

        private readonly HttpClient _httpClient;

        public ApiCallService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T?> GetAsync<T>(string uri)
        {

            var response = await _httpClient.GetAsync(uri);
         
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"HTTP status code: {response.StatusCode}");
                return await response.Content.ReadFromJsonAsync<T>();
            }
            else
            {
                throw new Exception($"HTTP code error: {response.StatusCode}");
            }
        }

    }
}
