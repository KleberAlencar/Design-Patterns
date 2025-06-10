namespace FacadePattern._01_Approach;

public class Client
{
    public static void ClientCode(Facade facade)
    {
        Console.WriteLine(facade.Operation());
    }
}