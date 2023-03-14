using BlazorStorageService.Model;
using Microsoft.JSInterop;
using System.Text.Json;


namespace BlazorStorageService.Service

{
    public class JsStorageService<T>
    {
        private readonly IJSRuntime _jsRuntime;

        public JsStorageService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        
        public async Task<List<T>> GetItemService(string key)
        {
            string json = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", key);
            if(json != null)
            {
                return FromJson(json);
            }
            else
            {
                return new List<T>();
            }
           
        }


        public async Task SetItemService(string key, string value)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, value);
        }

        public void LocalStorageClear()
        {
            _jsRuntime.InvokeVoidAsync("localStorage.clear");
        }

        public void localStorageRemoveAt(string key)
        {
            _jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
        }

        public string ToJson(List<T> value)
        {
            var opt = new JsonSerializerOptions() { WriteIndented = true };
            return JsonSerializer.Serialize<List<T>>(value, opt);
        }

        public List<T>? FromJson(string json)
        {
            return JsonSerializer.Deserialize<List<T>>(json);
        }
    }
}
