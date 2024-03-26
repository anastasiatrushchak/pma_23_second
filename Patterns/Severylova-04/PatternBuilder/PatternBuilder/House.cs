using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    public class House
    {
        public string color { get; set; }
        public int room { get; set; }
        public int floor{ get; set; }
        public int area { get; set; }

        public string ShowHouse() 
        {
            return "Floor: " + floor + " Room: " + room + " Area: " + area + " Color: " + color;
        }
    }
}
