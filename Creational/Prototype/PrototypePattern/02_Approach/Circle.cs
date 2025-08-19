namespace PrototypePattern._02_Approach;

public class Circle(int radius, Color color, string name) : IShape
{
    public string Name { get; set; } = name;
    
    public IShape Clone()
    {
        return new Circle(radius, color.Clone(), Name);
    }
}