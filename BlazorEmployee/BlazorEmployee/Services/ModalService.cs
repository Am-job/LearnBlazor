using BlazorEmployee.Modals;

namespace BlazorEmployee.Services
{
    public class ModalService
    {
      
        public event Action<string, object>? modalClick;

        public void NotifyStateChanged(string key, object obj) // object or T
        {
           // this.employee = employee;
            modalClick?.Invoke(key, obj);
        }


      //  private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
