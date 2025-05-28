namespace ObserverPattern._01_Approach;

public class School(string name) : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"School {name} received this message: {message}");       
    }
}