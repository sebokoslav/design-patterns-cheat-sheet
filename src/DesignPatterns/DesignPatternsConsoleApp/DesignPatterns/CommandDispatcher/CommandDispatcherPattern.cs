namespace DesignPatternsConsoleApp.DesignPatterns.CommandDispatcher
{
    /// <summary>
    /// The command dispatcher pattern serves to decouple the implementation of a command from its commander.
    /// Used in MediatR library.
    /// </summary>
    public class CommandDispatcherPattern
    {
        public static void DoYourThing()
        {
            Dispatcher dispatcher = new Dispatcher();
            CreateAuthorCommand createAuthorCommand = new CreateAuthorCommand()
            {
                AuthorName = "Jaroslav"
            };
            dispatcher.Dispatch(createAuthorCommand);
        }
    }
}
