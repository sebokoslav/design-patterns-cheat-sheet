namespace DesignPatternsConsoleApp.DesignPatterns.Mediator
{
    public interface IMediator
    {
        void SendMessage(Colleague caller, string msg);
        void Register(Colleague colleague);

    }
}
