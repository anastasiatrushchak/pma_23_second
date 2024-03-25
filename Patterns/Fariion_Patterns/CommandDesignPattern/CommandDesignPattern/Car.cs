using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern_
{
    class Car
    {
        public void StartEngine()
        {
            Console.WriteLine("Двигун запущено");
        }

        public void StopEngine()
        {
            Console.WriteLine("Двигун вимкнено");
        }
    }
}
