namespace MediatorDesignPattern.ChatApp
{
    public abstract class TeamMember
    {
        private Chatroom chatroom;
        public string Name { get; }

        protected TeamMember(string name)
        {
            Name = name.Trim();
        }
        
        internal void SetChatroom(Chatroom chatroom)
        {
            this.chatroom = chatroom;
        }

        public void SendMessage(string message)
        {
            chatroom.Send(this.Name, message);
        }

        public virtual void Receive(string from, string message) 
        {
            Console.Write($"from {from}: '{message}'");
        }

        public void SendTo<T>(string message) where T : TeamMember
        {
            chatroom.SendTo<T>(this.Name, message);
        }
    }
    public class Developer:TeamMember 
    {
        public Developer(string name):base(name) 
        { 
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"{this.Name} ({nameof(Developer)}) has received: " );
            base.Receive(from, message);
        }
    }

    public class Tester : TeamMember
    {
        public Tester(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"{this.Name} ({nameof(Tester)}) has received: ");
            base.Receive(from, message);
        }
    }
}