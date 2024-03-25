using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public abstract class MeetingState
    {
        protected Meeting _meeting;

        public void SetMeeting(Meeting meeting)
        {
            this._meeting = meeting;
        }

        public abstract void ConnectMeeting();
        public abstract void VideoMeeting();
        public abstract void ChatMeeting();
        public abstract void DisconnectMeeting();
    }
}
