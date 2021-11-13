namespace DesignPatternsConsoleApp.DesignPatterns.Command
{
    public class OnSwitchCommand : ICommand
    {
        private readonly Light _light;
        public OnSwitchCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.PowerOn();
        }
    }
}
