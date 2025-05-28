namespace ObserverPattern._01_Approach;

public interface ISubject
{
    void Register(IObserver observer);
    
    void Unregister(IObserver observer);
    
    void Notify(string message);   
}