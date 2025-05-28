namespace ObserverPattern._01_Approach;

public class User(string name) : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"User {name} received this message: {message}");       
    }
}