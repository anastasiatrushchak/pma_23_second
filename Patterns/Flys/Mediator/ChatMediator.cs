using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator
{
    public class ChatMediator : InterfaceChatMediator
    {
        private List<User> users;

        public ChatMediator()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in users)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
