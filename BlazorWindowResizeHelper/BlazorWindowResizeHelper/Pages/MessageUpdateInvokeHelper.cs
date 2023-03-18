using Microsoft.JSInterop;

namespace BlazorWindowResizeHelper.Pages
{
    public class MessageUpdateInvokeHelper
    {
        private Action action;

        public MessageUpdateInvokeHelper(Action action)
        {
            this.action = action;
        }

        [JSInvokable]
        public void UpdateMessageCaller()
        {
            action.Invoke();
        }
    }
}
