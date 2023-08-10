namespace MediatorDesignPattern.Structural
{
    // Mediator knows about all the Collegues and each Colegue knows about it's single Mediator
    public abstract class Colleague
    {
        protected Mediator mediator;

        // Each Collegue knows about it's single Mediator
        public Colleague(Mediator mediator)
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

    public class Collegue1 : Colleague
    {
        public Collegue1(Mediator mediator): base(mediator)
        {
        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Col1 gets message : {message}");
        }
    }

    public class Collegue2 : Colleague
    {
        public Collegue2(Mediator mediator) : base(mediator)
        {
            //Gives the ability to call base.Send();
        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Col2 gets message : {message}");
        }
    }
}