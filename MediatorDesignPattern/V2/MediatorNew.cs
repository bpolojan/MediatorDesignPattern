using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorDesignPattern.Structural;

namespace MediatorDesignPattern.V2
{
    public abstract class MediatorNew
    {
        public abstract void Send(string message, Teammate colleague);
    }

    public class ConcreteMediatorNew : MediatorNew
    {
        private List<Teammate> matesList = new List<Teammate>();
        public T CreateCollegue<T>() where T : Teammate, new()
        {
            var c = new T();    // Create Teammate
            c.SetMediator(this);// Set mediator to Teammate
            matesList.Add(c);   // Add Teammate to List
            return c;
        }

        //On send - send messages to all other neighbours
        public override void Send(string message, Teammate mate)
        {
            matesList.Where(c => c != mate).ToList().ForEach(c => c.HandleNotification(message));             
        }
    }
}
