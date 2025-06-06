namespace StrategyPattern._02_Approach;

// The Context defines the interface of interest to clients
public class Context
{
    private IStrategy _strategy;

    public Context()
    {
    }

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    // The Context delegates some work to the Strategy object instead of
    // implementing multiple versions of the algorithm on its own    
    public void DoSomething()
    {
        Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
        var result = _strategy.DoAlgorithm(new List<string>() { "A", "B", "C", "D", "E" });
        
        string resultString = string.Empty;
        foreach (var element in result as List<string>)
        {
            resultString += element + ",";
        }
        
        Console.WriteLine(resultString);
    }
}