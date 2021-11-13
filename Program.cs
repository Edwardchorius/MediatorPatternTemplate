using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main()
        {
            var chatroom = new Chatroom();

            Participant chatMember = new ConcreteParticipant("Georgy");

            chatroom.Join(chatMember);

            chatMember.Send("someone", "hey");
        }
    }
}
