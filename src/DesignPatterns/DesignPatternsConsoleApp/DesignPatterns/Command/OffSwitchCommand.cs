namespace DesignPatternsConsoleApp.DesignPatterns.Command
{
    public class OffSwitchCommand : ICommand
    {
        private readonly Light _light;
        public OffSwitchCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.PowerOff();
        }
    }
}
