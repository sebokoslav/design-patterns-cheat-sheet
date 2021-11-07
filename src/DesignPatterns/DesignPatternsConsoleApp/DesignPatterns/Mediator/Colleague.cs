namespace DesignPatternsConsoleApp.DesignPatterns.Mediator
{
    public abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
            if (_mediator != null) _mediator.Register(this);
        }

        public abstract void Send(string msg);
        public abstract void Receive(string msg);

    }
}
