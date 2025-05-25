namespace AdapterPattern;

public class RainbowThirdParty
{
    public void ApplyColor()
    {
        Console.WriteLine("Applying rainbow color to video");       
    }

    public void ApplyFilter(IVideo video)
    {
        Console.WriteLine("Applying rainbow filter to video");       
    }
}