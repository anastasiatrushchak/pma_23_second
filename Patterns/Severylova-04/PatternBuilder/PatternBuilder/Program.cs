using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                House house;
                HouseDirector director = new HouseDirector();

                Console.WriteLine("Big house");

                BigHouse big = new BigHouse();
                house = director.MakeHouse(big);
                Console.WriteLine(house.ShowHouse());

                Console.WriteLine("\nSmall house");

                SmallHouse small = new SmallHouse();
                house = director.MakeHouse(small);
                Console.WriteLine(house.ShowHouse());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

            Console.ReadKey();

        }
    }
}
