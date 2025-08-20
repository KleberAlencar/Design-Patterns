namespace ProxyPattern._01_Approach;

public class Proxy : ISubject
{
    private RealSubject? _realSubject = null;
    
    public Proxy()
    {
        Console.WriteLine("1. Proxy: Instantiating Proxy");
    }
    
    public void Operation()
    {
        Console.WriteLine("2. Proxy: Performing operation in Proxy");

        if (_realSubject is null)
        {
            Console.WriteLine("3. Proxy: RealSubject is null, creating it");
            _realSubject = new RealSubject();
        }
        
        Console.WriteLine("5. Proxy: Logging before Operation");
        _realSubject.Operation();
        Console.WriteLine("7. Proxy: Logging after Operation");
    }    
}