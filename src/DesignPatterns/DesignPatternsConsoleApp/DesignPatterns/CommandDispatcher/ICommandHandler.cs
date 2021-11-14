namespace DesignPatternsConsoleApp.DesignPatterns.CommandDispatcher
{
    public interface ICommandHandler<TCommand> where TCommand : class
    {
        void Handle(TCommand command);
    }
}
