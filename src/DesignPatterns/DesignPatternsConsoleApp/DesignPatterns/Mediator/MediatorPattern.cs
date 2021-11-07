namespace DesignPatternsConsoleApp.DesignPatterns.Mediator
{
    public class MediatorPattern
    {
        public static void DoYourThing()
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleagueA colleagueA = new ConcreteColleagueA(mediator);
            ConcreteColleagueB colleagueB = new ConcreteColleagueB(mediator);

            colleagueA.Send("Hey B!");
            colleagueB.Send("Whazzup A!");
        }
    }
}
