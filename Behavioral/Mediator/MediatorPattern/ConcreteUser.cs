namespace MediatorPattern;

// Concrete Colleague
public class ConcreteUser(IGroupMediator mediator, string name) : User(mediator, name)
{
    public override void Send(string message)
    {
        Console.WriteLine($"{name} sending: {message}");
        mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{name} receiving: {message}");
    }
}