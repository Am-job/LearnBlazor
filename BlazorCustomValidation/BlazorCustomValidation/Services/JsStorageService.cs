using BlazorCustomValidation.Model;
using Microsoft.JSInterop;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorCustomValidation.Services

{
    public class JsStorageService
    {
        private readonly IJSRuntime _jsRuntime;

        public JsStorageService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task SetItemAsync(string key, object value)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, value);
        }

        public async Task<string> GetItemAsync(string key)
        {
            return await _jsRuntime.InvokeAsync<string>("localStorage.getItem", key);
        }

        public async Task DeleteAllKey()
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.clear");
        }

        public async Task DeleteOneKey(string key)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
        }

        public string ToJson(List<Person> value)
        {
            var opt = new JsonSerializerOptions() { WriteIndented = true };
            return JsonSerializer.Serialize<List<Person>>(value, opt);
        }

        public List<Person>? FromJson(string json)
        {
            return JsonSerializer.Deserialize<List<Person>>(json);
        }
    }
}
