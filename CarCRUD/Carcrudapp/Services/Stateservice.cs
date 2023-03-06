namespace Carcrudapp.Services
{
    public class Stateservice
    {
        public event Action<object>? onChange;
        public void NotifyStateChanged(object obj) => onChange?.Invoke(obj);
        public void UpdataData(object cardata)
        {
            NotifyStateChanged(cardata);
        }
    }
}
