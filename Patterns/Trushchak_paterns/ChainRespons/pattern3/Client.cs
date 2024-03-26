using pattern3;
using System;
using System.Collections.Generic;

namespace pattern3
{
    class Client
    {
        // Обычно клиентский код приспособлен для работы с единственным
        // обработчиком. В большинстве случаев клиенту даже неизвестно, что этот
        // обработчик является частью цепочки.
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var item in new List<string> { "Fruits", "Electronics", "Books" })
            {
                Console.WriteLine($"Client: Do you have {item}?");

                var result = handler.Handle(item);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {item} was not handled.");
                }
            }
        }
    }
}
