namespace CompositePattern._01_Approach;

public abstract class Component(string message)
{
    public abstract void Operation();

    public virtual void Add(Component component){}
    
    public virtual void Remove(Component component){}
    
    public virtual Component? GetChild(int index)
    {
        return null;
    }
}