namespace MediatorPattern;

// Concrete Mediator
public class ConcreteGroupMediator : IGroupMediator
{
    private List<User> _users = new();

    public void RegisterUser(User user)
    {
        _users.Add(user);
    }    
    
    public void SendMessage(string message, User user)
    {
        foreach (var item in _users)
        {
            if (item != user)
                item.Receive(message);
        }
    }
}