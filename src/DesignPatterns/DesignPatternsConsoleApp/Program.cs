using DesignPatternsConsoleApp.DesignPatterns.Command;
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
            Console.WriteLine("Command");
            CommandPattern.DoYourThing();
        }
    }
}
