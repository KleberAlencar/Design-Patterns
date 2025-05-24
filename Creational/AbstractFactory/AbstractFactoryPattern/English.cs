namespace AbstractFactoryPattern;

// Concrete Product A1
public class English : ILanguage
{
    public void Greet()
    {
        Console.WriteLine("Hello");
    }
}