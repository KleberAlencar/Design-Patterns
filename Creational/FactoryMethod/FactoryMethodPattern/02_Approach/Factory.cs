namespace FactoryMethodPattern._02_Approach;

// The Factory class declares the factory method supposed to return
// an object of a Product class. The Factory's subclasses usually provide
// the implementation of this method.
public abstract class Factory
{
    public abstract IProduct FactoryMethod();

    public string SomeOperation()
    {
        var product = FactoryMethod();

        var result = $"Creator: The same creator's code has just worked with {product.Operation()}";
        return result;
    }
}