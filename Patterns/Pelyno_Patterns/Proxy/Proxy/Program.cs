using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase data_1 = new DatabaseProxy("admin", "admin123");
            data_1.UpdateData("New data for updating");

            IDatabase data_2 = new DatabaseProxy("guest", "password");
            data_2.UpdateData("Attempt to update with incorrect data");
        }
    }
}
