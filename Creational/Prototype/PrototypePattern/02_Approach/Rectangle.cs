namespace PrototypePattern._02_Approach;

public class Rectangle(int width, int height, Color color, string name) : IShape
{
    public string Name { get; set; } = name;
    
    public IShape Clone()
    {
        return new Rectangle(width, height, color.Clone(), Name);
    }
}