using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    abstract class AbstractChatroom

    {
        public abstract void Join(Participant participant);
        public abstract void Send(
          string from, string to, string message);
    }
}
