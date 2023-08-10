using MediatorDesignPattern.ChatApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Structural
{
    internal class ColleagueProgram
    {
        public void Run()
        {
            var mediator = new ConcreteMediator();

            //Each Collegue has 1 Mediator
            var c1 = new Collegue1(mediator);
            var c2 = new Collegue2(mediator);

            //Mediator knows ALL the Collegues
            mediator.Collegue1 = c1;
            mediator.Collegue2 = c2;

            c1.Send("Hello, World from Collegue1");
            c2.Send("Hello, World from Collegue2");
        }
    }
}
