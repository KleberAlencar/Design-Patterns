namespace DecoratorPattern;

public class Client
{
    public void ClientCode(Component component)
    {
        Console.WriteLine("RESULT: " + component.Operation());
    }
}