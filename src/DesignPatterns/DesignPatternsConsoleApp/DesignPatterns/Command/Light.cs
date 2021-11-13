using System;

namespace DesignPatternsConsoleApp.DesignPatterns.Command
{
    public class Light
    {
        public void PowerOn()
        {
            Console.WriteLine("The light is on");
        }

        public void PowerOff()
        {
            Console.WriteLine("The light is off");
        }
    }
}
