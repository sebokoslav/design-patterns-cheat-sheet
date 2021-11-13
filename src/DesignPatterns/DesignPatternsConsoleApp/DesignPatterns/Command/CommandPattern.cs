namespace DesignPatternsConsoleApp.DesignPatterns.Command
{
    public class CommandPattern
    {
        public static void DoYourThing()
        {
            Light light = new Light();
            ICommand switchOffCommand = new OffSwitchCommand(light);
            ICommand switchOnCommand = new OnSwitchCommand(light);
            Switch @switch = new Switch(switchOffCommand, switchOnCommand);
            @switch.On();
            @switch.Off();
        }
    }
}
