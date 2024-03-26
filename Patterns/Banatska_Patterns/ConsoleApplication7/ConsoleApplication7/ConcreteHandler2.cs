using System;
namespace ConsoleApplication7
{
    public class ConcreteHandler2 : BaseHandler
    {
        public void HandleRequest(Request request)
        {
            if (request.Type == RequestType.Type2)
            {
                Console.WriteLine("Request handled by ConcreteHandler2");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }

}