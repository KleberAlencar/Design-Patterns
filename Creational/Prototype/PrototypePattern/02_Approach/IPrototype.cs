namespace PrototypePattern._02_Approach;

// IPrototype interface defines the Clone method for creating a copy of an object
public interface IPrototype<T>
{
    T Clone();
}