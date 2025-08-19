namespace PrototypePattern._02_Approach;

public class Color(ushort red, ushort green, ushort blue) : IPrototype<Color>
{
    public static readonly Color LightGray = new(217, 217, 217);

    public Color Clone()
    {
        return new(red, green, blue);
    }
}