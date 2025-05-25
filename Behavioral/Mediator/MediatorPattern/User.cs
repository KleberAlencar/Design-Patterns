namespace MediatorPattern;

// Colleague
public abstract class User
{
    protected IGroupMediator mediator;
    protected string name;

    public User(IGroupMediator mediator, string name)
    {
        this.mediator = mediator;
        this.name = name;
    }
    
    public abstract void Send(string message);
    public abstract void Receive(string message);
}