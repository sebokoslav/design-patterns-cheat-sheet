namespace DesignPatternsConsoleApp.DesignPatterns.Command
{
    public class Switch
    {
        private readonly ICommand _offCommand;
        private readonly ICommand _onCommand;

        public Switch(ICommand offCommand, ICommand onCommand)
        {
            _offCommand = offCommand;
            _onCommand = onCommand;
        }

        public void Off()
        {
            _offCommand.Execute();
        }

        public void On()
        {
            this._onCommand.Execute();
        }
    }
}
