namespace FactoryPattern._02_Approach;

public class ConcreteFactory1 : Factory
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}