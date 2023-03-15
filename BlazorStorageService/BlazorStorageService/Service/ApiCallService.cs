using System.Net.Http.Json;

namespace BlazorStorageService.Service
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
            try
            {
                var response = await _httpClient.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<T>();
            }catch(Exception ex)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", ex.Message);
                return default;
            }
        }

    }
}
