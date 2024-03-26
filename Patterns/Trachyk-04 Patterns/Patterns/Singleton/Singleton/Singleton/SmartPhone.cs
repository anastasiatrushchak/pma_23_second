using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SmartPhone : Phone
    {
        private static SmartPhone? instance;
        private static string? brand;

        private SmartPhone(string brand)
        {
            SmartPhone.brand = brand;
        }

        public static SmartPhone GetInstance(string brand)
        {
            if (instance == null)
            {
                instance = new SmartPhone(brand);
            }

            return instance;
        }

        public override void Call(string number)
        {
            Console.WriteLine($"Calling {number} from {brand} smartphone");
        }
    }
}
