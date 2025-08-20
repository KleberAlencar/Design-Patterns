namespace ProxyPattern._01_Approach;

public class RealSubject : ISubject
{
    public RealSubject()
    {
        Console.WriteLine("4. RealSubject: Instantiating RealSubject");
    }
    
    public void Operation()
    {
        Console.WriteLine("6. RealSubject: Performing operation in RealSubject");
    }
}