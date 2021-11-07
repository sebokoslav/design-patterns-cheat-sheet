using System;

namespace DesignPatternsConsoleApp.DesignPatterns.Mediator
{
    public class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(IMediator mediator) : base(mediator) {}

        public override void Send(string msg)
        {
            Console.WriteLine("A sent message:" + msg);
            _mediator.SendMessage(this, msg);
        }

        public override void Receive(string msg)
        {
            Console.WriteLine("A received message:" + msg);
        }
    }
}
