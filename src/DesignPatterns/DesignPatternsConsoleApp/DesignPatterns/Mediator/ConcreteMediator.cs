using System.Collections.Generic;

namespace DesignPatternsConsoleApp.DesignPatterns.Mediator
{
    public class ConcreteMediator : IMediator
    {
        private readonly List<Colleague> _colleagues;

        public ConcreteMediator()
        {
            _colleagues = new List<Colleague>();
        }

        public void Register(Colleague colleague)
        {
            _colleagues.Add(colleague);
        }

        public void SendMessage(Colleague caller, string msg)
        {
            foreach(var c in _colleagues)
            {
                if (c != caller) c.Receive(msg);
            }
        }
    }
}
