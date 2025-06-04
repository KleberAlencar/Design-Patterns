namespace DecoratorPattern;

public class ConcreteDecoratorA(Component component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorA({_component.Operation()})";
    }
}