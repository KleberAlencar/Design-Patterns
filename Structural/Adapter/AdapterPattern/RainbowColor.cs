namespace AdapterPattern;

public class RainbowColor(RainbowThirdParty rainbowThirdParty) : IColor
{
    public void Apply(IVideo video)
    {
        rainbowThirdParty.ApplyColor();       
        rainbowThirdParty.ApplyFilter(video);       
    }
}