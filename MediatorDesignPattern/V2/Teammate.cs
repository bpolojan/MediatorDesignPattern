using MediatorDesignPattern.Structural;

namespace MediatorDesignPattern.V2
{

    public abstract class Teammate
    {
        protected MediatorNew mediator;

        // Each Collegue knows about it's single Mediator    
        public void SetMediator(MediatorNew mediator)
        {
            this.mediator = mediator;
        }

        // Send Messages to the Mediator
        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        //When we need to receive Messages
        public abstract void HandleNotification(string message);
    }

    public class Teammate1 : Teammate
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Teammate1 gets message : {message}");
        }
    }

    public class Teammate2 : Teammate
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Teammate2 gets message : {message}");
        }
    }
}