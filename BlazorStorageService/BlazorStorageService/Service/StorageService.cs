using BlazorStorageService.Model;
using System.Text.Json;

namespace BlazorStorageService.Service
{
    public class StorageService
    {

        private readonly JsStorageService jsStorageService;

        public StorageService(JsStorageService jsStorageService)
        {
            this.jsStorageService = jsStorageService;
        }
        public Dictionary<string, dynamic> Storage { get; set; } = new Dictionary<string, dynamic>();


        public dynamic? Get(string key)
        {
            bool keyExits = Storage.ContainsKey(key);
            if (keyExits)
            {
                return Storage[key];
            }
            else
            {
                return null;
            }
        }

        public void Set(string key, dynamic value)
        {
            Storage[key] = value;
        }

        public async Task GetDataFromBrowser<T>(string key)
        {
            var response = await jsStorageService.GetItemService(key);
            var data = response != null ? JsonSerializer.Deserialize<List<T>>(response) : null;
            if(data != null && data.Count > 0)
            {
                Set(key, data);
            }
        }
    }
}
