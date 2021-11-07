using System;

namespace DesignPatternsConsoleApp.DesignPatterns.Mediator
{
    public class ConcreteColleagueB : Colleague
    {
        public ConcreteColleagueB(IMediator mediator) : base(mediator) { }

        public override void Send(string msg)
        {
            Console.WriteLine("B sent message:" + msg);
            _mediator.SendMessage(this, msg);
        }

        public override void Receive(string msg)
        {
            Console.WriteLine("B received message:" + msg);
        }
    }
}
