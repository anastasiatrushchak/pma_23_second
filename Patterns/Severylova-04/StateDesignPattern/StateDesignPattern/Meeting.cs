using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class Meeting
    {
        public MeetingState _state;

        public Meeting(MeetingState state)
        {
            Transition(state);
        }

        public void Transition(MeetingState state)
        {
            Console.WriteLine($"Meeting state: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetMeeting(this);
        }

        public void RequestConnect()
        {
            _state.ConnectMeeting();
        }

        public void RequestVideo()
        {
            _state.VideoMeeting();
        }

        public void RequestChat()
        {
            _state.ChatMeeting();
        }

        public void RequestDisconnect()
        {
            _state.DisconnectMeeting();
        }
    }
}
