namespace CompositePattern._01_Approach;

public class Composite(string message) : Component(message)
{
    private readonly List<Component> _children = [];
    private readonly string _message = message;

    public override void Operation()
    {
        foreach (var child in _children)
        {
            child.Operation();
        }
    }

    public override void Add(Component component)
    {
        _children.Add(component);
        Console.WriteLine($"Composite: Component added {_message}");
    }

    public override void Remove(Component component)
    {
        _children.Remove(component);
        Console.WriteLine($"Composite: Component removed {_message}");
    }
    
    public override Component? GetChild(int index)
    {
        if (index < 0 || index > _children.Count - 1)
        {
            return null; // or throw an exception
        }
        
        return _children[index];
    }
}