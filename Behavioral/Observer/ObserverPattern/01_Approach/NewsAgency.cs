namespace ObserverPattern._01_Approach;

public class NewsAgency() : ISubject
{
    private readonly List<IObserver> observers = [];
    
    public void Register(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unregister(IObserver observer)
    {
        observers.Remove(observer);       
    }

    public void Notify(string message)
    {
        observers.ForEach(observer => observer.Update(message));       
    }
}