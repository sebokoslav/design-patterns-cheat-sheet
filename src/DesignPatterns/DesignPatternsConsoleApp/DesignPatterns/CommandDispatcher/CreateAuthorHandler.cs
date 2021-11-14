using System;

namespace DesignPatternsConsoleApp.DesignPatterns.CommandDispatcher
{
    public class CreateAuthorHandler : ICommandHandler<CreateAuthorCommand>
    {
        public void Handle(CreateAuthorCommand command)
        {
            Console.WriteLine($"{command.AuthorName} will be added to Authors");
        }
    }
}
