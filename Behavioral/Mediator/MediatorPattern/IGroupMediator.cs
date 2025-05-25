namespace MediatorPattern;

// Mediator
public interface IGroupMediator
{
    void RegisterUser(User user);
    
    void SendMessage(string message, User user);
}