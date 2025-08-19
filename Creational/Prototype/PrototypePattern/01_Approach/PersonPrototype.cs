namespace PrototypePattern._01_Approach;

// Prototype class
public abstract class PersonPrototype(string name)
{
    public string Name { get; set; } = name;

    public abstract PersonPrototype Clone();
}