namespace PrototypePattern._02_Approach;

public interface IShape : IPrototype<IShape>
{
    public string Name { get; set; }
}