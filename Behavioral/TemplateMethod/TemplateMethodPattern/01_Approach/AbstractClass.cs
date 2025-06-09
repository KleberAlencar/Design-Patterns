namespace TemplateMethodPattern._01_Approach;

public abstract class AbstractClass
{
    // The Abstract Class defines a template method that contains a skeleton of
    // some algorithm, composed of calls to (usually) abstract primitive operations
    // Concrete subclasses should implement these operations, but leave the
    // template method itself intact
    public void TemplateMethod()
    {
        BaseOperation1();
        RequiredOperations1();
        BaseOperation2();
        Hook1();
        RequiredOperations2();
        BaseOperation3();
        Hook2();
    }

    protected void BaseOperation1()
    {
        Console.WriteLine("AbstractClass says: I'm doing the bulk of the work");
    }

    protected void BaseOperation2()
    {
        Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
    }

    protected void BaseOperation3()
    {
        Console.WriteLine("AbstractClass says: I'm doing the bulk of the work anyway");
    }
    
    // These operations HAVE to be implemented in subclasses
    protected abstract void RequiredOperations1();
    protected abstract void RequiredOperations2();

    // These operations SHOULD be implemented in subclasses
    protected virtual void Hook1() {}
    protected virtual void Hook2() {}
}