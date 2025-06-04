namespace DecoratorPattern;

public class ConcreteDecoratorB(Component component) : Decorator(component)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorB({_component.Operation()})";
    }
}