using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.V2
{
    internal class TeammateProgram
    {
        public void Run()
        {
            var mediator = new ConcreteMediatorNew();

            //Encapsulates the Creation of the Collegues and the setting up of the biderectional communication
            var teammate1 = mediator.CreateCollegue<Teammate1>();
            var teammate2 = mediator.CreateCollegue<Teammate2>();
            var teammate3 = mediator.CreateCollegue<Teammate2>();

            teammate1.Send("Hello, World from teammate1");
            teammate2.Send("Hello, World from teammate2");
        }
    }
}
