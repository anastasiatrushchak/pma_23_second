using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator
{
    public abstract class User
    {
        protected InterfaceChatMediator chatMediator;

        public User(InterfaceChatMediator chatMediator)
        {
            this.chatMediator = chatMediator;
        }
        public virtual void Send(string message)
        {
            if (string.IsNullOrEmpty(message)){
                throw new ArgumentNullException("Message cannot be null or empty"); 
            }
            chatMediator.SendMessage(message, this);
        }
        public abstract void Receive(string message);

    }
}
