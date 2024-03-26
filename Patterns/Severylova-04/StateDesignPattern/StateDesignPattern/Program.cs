using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting = new Meeting(new AbcentFromTheMeeting());
            meeting.RequestConnect();
            meeting.RequestVideo();
            meeting.RequestChat();
            meeting.RequestDisconnect();

            meeting.RequestConnect();
            meeting.RequestVideo();
            meeting.RequestChat();
            meeting.RequestDisconnect();

            Console.ReadKey();
        }
    }
}
