

namespace BlazorStorageService.Service
{
    public class StorageService<T>
    {
        private readonly JsStorageService<T> _jsStorageService;

        public StorageService(JsStorageService<T> jsStorageService)
        {
            _jsStorageService = jsStorageService;
        }

        public List<T>? datas;

        public async Task GetDataFromBrowser(string key)
        {
            datas = await _jsStorageService.GetItemService(key);
        }

        public List<T>? GetData()
        {
            if (datas != null)
            {
                return datas;
            }
            else
            {
                return new List<T>(); ;
            }
        }

        public void SetData(List<T> data)
        {
            datas = data;
        }
    }
}
