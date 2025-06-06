namespace StrategyPattern._02_Approach;

public class ConcreteStrategyB : IStrategy
{
    public object DoAlgorithm(object data)
    {
        var list = data as List<string>;
        list.Sort();
        list.Reverse();
        
        return list;
    }
}