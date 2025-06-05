namespace FactoryPattern._02_Approach;

public class Client
{
    public void ClientCode(Factory factory)
    {
        Console.WriteLine("Client: I'm not aware of the creator's class," +
                          "but it still works.\n" + factory.SomeOperation());
    }
}