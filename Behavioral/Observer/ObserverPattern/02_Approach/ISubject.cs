namespace ObserverPattern._02_Approach;

public interface ISubject
{
    void Attach(IObserver observer, string name);
    
    void Detach(IObserver observer, string name);
    
    void Notify();  
}