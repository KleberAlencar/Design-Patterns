namespace DecoratorPattern;

public abstract class Component
{
    // The base Component interface defines operations that can be altered by decorators
    public abstract string Operation();
}