namespace AdapterPattern;

public class MidnightColor : IColor
{
    public void Apply(IVideo video)
    {
        Console.WriteLine("Applying midnight color to video");
    }
}