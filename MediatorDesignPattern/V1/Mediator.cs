namespace MediatorDesignPattern.Structural
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    public class ConcreteMediator : Mediator
    {
        public Collegue1 Collegue1 { get; set; }
        public Collegue2 Collegue2 { get; set; }
        public override void Send(string message, Colleague colleague)
        {
            // If Collegue 1 is sending the Message -> Send the Message to Collegue2
            // Collegues are sending Messages to eachother

            if (colleague == this.Collegue1) 
            { 
                Collegue2.HandleNotification(message);
            }
            else
            {
                Collegue1.HandleNotification(message);
            }     
        }
    }
}
