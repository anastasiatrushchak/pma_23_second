using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone phone1 = SmartPhone.GetInstance("Nokia");
            Console.WriteLine(phone1.GetHashCode());
            phone1.Call("123-456-789");

            SmartPhone phone2 = SmartPhone.GetInstance("Apple");
            Console.WriteLine(phone2.GetHashCode());
            phone2.Call("987-654-321");

            // Перевірка, що обидва екземпляри мають однаковий хеш-код, що підтверджує, що вони є тим самим об'єктом
            Console.WriteLine(phone1.GetHashCode() == phone2.GetHashCode()); 
        }
    }
}
