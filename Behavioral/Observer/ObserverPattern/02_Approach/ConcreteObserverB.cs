namespace ObserverPattern._02_Approach;

public class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as Subject).State is 0 or >= 2)
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event!");       
        }
    }
}