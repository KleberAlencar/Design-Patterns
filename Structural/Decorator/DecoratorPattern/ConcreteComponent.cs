namespace DecoratorPattern;

public class ConcreteComponent : Component
{
    // Concrete Components provide default implementations of the operations
    // There might be several variations of these classes    
    public override string Operation()
    {
        return "ConcreteComponent";
    }
}