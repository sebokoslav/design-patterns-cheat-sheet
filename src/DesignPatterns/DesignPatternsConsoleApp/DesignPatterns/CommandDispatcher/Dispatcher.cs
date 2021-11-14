using System;
using System.Linq;
using System.Reflection;

namespace DesignPatternsConsoleApp.DesignPatterns.CommandDispatcher
{
    /// <summary>
    /// Scans the assembly for classes implementing ICommandHadler of which the generic type is TCommand and executes Handle method.
    /// </summary>
    public class Dispatcher
    {
        public void Dispatch<TCommand>(TCommand command) where TCommand : class
        {
            Type handler = typeof(ICommandHandler<>);
            Type handlerType = handler.MakeGenericType(command.GetType());

            Type[] concreteTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass && t.GetInterfaces().Contains(handlerType)).ToArray();

            if (!concreteTypes.Any()) return;

            foreach(Type type in concreteTypes)
            {
                var concreteHandler = Activator.CreateInstance(type) as ICommandHandler<TCommand>;
                concreteHandler?.Handle(command);
            }
        }
    }
}
