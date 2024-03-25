using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class PresentAtTheMeeting : MeetingState
    {
        public override void ConnectMeeting()
        {
            Console.WriteLine("Connected");
        }

        public override void VideoMeeting()
        {
            Console.WriteLine("Starting video call");
        }

        public override void ChatMeeting()
        {
            Console.WriteLine("Opening chat");
        }

        public override void DisconnectMeeting()
        {
            Console.WriteLine("Disconnecting");
            _meeting.Transition(new AbcentFromTheMeeting());
        }
    }
}
