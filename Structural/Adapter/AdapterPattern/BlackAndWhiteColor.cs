namespace AdapterPattern;

public class BlackAndWhiteColor : IColor
{
    public void Apply(IVideo video)
    {
        Console.WriteLine("Applying black and white color to video");
    }
}