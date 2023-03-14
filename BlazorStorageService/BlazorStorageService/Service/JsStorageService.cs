using Microsoft.JSInterop;
using System.Text.Json;


namespace BlazorStorageService.Service

{
    public class JsStorageService
    {
        private readonly IJSRuntime _jsRuntime;

        public JsStorageService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        
        public async Task<T> GetItemService<T>(T key)
        {
            var json = await _jsRuntime.InvokeAsync<T>("localStorage.getItem", key);
            if(json != null)
            {
                return json;
            }
            else
            {
                return default;
            }
        }


        public async Task SetItemService<T>(T key,T value)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, value);
        }

        public void LocalStorageClear()
        {
            _jsRuntime.InvokeVoidAsync("localStorage.clear");
        }

        public void localStorageRemoveAt<T>(T key)
        {
            _jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
        }

    }
}
