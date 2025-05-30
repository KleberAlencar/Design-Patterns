namespace ObserverPattern._02_Approach;

public class Subject : ISubject
{
    public int State { get; set; } = -0;
    
    private List<IObserver> _observers = [];
    
    public void Attach(IObserver observer, string name)
    {
        Console.WriteLine($"Subject: Attaching observer {name}!");
        _observers.Add(observer);       
    }

    public void Detach(IObserver observer, string name)
    {
        Console.WriteLine($"Subject: Detaching observer {name}");
        _observers.Remove(observer);
    }

    public void Notify()
    {
        Console.WriteLine("Subject: Notifying observers...");
        
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }
    
    public void SomeBusinessLogic()
    {
        Console.WriteLine("\nSubject: Performing some business logic...");
        State = new Random().Next(0, 10);
        
        Thread.Sleep(10);
        
        Console.WriteLine($"Subject: State has been updated to: {State};");
        Notify();
    }   
}