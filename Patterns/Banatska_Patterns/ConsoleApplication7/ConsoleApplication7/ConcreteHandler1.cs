using System;
namespace ConsoleApplication7
{
    public class ConcreteHandler1 : BaseHandler
    {
        public void HandleRequest(Request request)
        {
            if (request.Type == RequestType.Type1)
            {
                Console.WriteLine("Request handled by ConcreteHandler1");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}