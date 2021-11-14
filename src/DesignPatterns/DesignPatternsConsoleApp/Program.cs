using DesignPatternsConsoleApp.DesignPatterns.Command;
using DesignPatternsConsoleApp.DesignPatterns.CommandDispatcher;
using DesignPatternsConsoleApp.DesignPatterns.Mediator;
using System;

namespace DesignPatternsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mediator");
            MediatorPattern.DoYourThing();
            Console.WriteLine();

            Console.WriteLine("Command");
            CommandPattern.DoYourThing();
            Console.WriteLine();

            Console.WriteLine("Command Dispatcher");
            CommandDispatcherPattern.DoYourThing();
            Console.WriteLine();
        }
    }
}
