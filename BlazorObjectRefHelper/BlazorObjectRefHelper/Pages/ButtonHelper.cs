using Microsoft.JSInterop;

namespace BlazorObjectRefHelper.Pages
{
    public class ButtonHelper
    {
        public string? Name { get; set; }
        private readonly IJSRuntime js;

        [JSInvokable]
        public string GetHelloMessage() => $"Hello, {Name}!";

        public ButtonHelper(IJSRuntime js)
        {
            this.js = js;
        }
        public ButtonHelper(IJSRuntime js, string name)
        {
            this.js = js;
            Name= name;
        }

        public async ValueTask<string> CallButtonHelperGetHelloMessage(string name)
        {
            using var objRef = DotNetObjectReference.Create(new ButtonHelper(js, name));
            return await js.InvokeAsync<string>("sayHello1", objRef);
        }
    }
}

