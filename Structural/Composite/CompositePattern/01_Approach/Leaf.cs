namespace CompositePattern._01_Approach;

public class Leaf(string message) : Component(message)
{
    private readonly string _message = message;

    public override void Operation()
    {
        // Leaf-specific operation logic
        Console.WriteLine($"Leaf: Operation executed {_message}");
    }
}