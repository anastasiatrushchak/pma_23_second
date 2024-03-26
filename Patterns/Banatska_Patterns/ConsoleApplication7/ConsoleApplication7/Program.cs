namespace ConsoleApplication7
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();

            handler1.SetNext(handler2);
            
            var request1 = new Request(RequestType.Type1);
            handler1.HandleRequest(request1);

            var request2 = new Request(RequestType.Type2);
            handler1.HandleRequest(request2);
        }
    }

}