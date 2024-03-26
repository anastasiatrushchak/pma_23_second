namespace ConsoleApplication7
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        void HandleRequest(Request request);
    }

    public abstract class BaseHandler : IHandler
    {
        private IHandler nextHandler;

        public void SetNext(IHandler handler)
        {
            nextHandler = handler;
        }

        public void HandleRequest(Request request)
        {
            if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }

}