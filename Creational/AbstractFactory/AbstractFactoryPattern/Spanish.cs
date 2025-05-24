namespace AbstractFactoryPattern;

// Concrete Product A2
public class Spanish : ILanguage
{
    public void Greet()
    {
        Console.WriteLine("Hola");
    }
}