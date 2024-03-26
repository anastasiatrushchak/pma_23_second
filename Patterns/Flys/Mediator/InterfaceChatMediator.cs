using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator
{
    public interface InterfaceChatMediator
    {
        void SendMessage(string message, User user);
        void AddUser(User user);
    }
}
