namespace CommandPattern._01_Approach;

public class ComplexCommand(Receiver receiver, string a, string b) : ICommand
{
    // Complex commands can accept one or several receiver objects along
    // with any context data via the constructor
    // Commands can delegate to any methods of a receiver
    public void Execute()
    {
        Console.WriteLine($"ComplexCommand: Complex stuff should be done by a receiver object ({receiver.GetType().Name})");
        receiver.DoSomething(a);
        receiver.DoSomethingElse(b);
    }
}