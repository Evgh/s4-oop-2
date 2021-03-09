using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4_oop_2
{
    public interface ICommand
    {
        void Execute();
    }

    public abstract class Command : ICommand
    {
        protected Executer _executer;
        public Command(Executer executer)
        {
            _executer = executer;
        }
        public abstract void Execute();
    }

    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Executer e) : base(e) { }
        public override void Execute()
        {
            _executer.DoThing();            
        }
    }

    public class Executer
    {
        public void DoThing()
        {

        }
    }

    public class AnotherExecuter : Executer
    {

    }
}
