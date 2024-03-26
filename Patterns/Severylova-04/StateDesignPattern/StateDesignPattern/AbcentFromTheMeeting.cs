using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class AbcentFromTheMeeting : MeetingState
    {
        public override void ConnectMeeting()
        {
            Console.WriteLine("Connecting...........");
        }

        public override void VideoMeeting()
        {
            Console.WriteLine("Cannot start video call");
        }

        public override void ChatMeeting()
        {
            Console.WriteLine("Cannot open chat");
        }

        public override void DisconnectMeeting()
        {
            _meeting.Transition(new PresentAtTheMeeting());
        }
    }
}
