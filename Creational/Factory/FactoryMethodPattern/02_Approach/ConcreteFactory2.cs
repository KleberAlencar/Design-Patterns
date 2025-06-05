namespace FactoryPattern._02_Approach;

public class ConcreteFactory2 : Factory
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct2();
    }
}