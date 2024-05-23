using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        linkedList.Append(0);
        linkedList.Append(1);
        linkedList.Append(2);

        linkedList.Display();

        linkedList.AppendAt(4, 2);
        linkedList.DeleteAt(1);
        linkedList.Display();
    }
}



