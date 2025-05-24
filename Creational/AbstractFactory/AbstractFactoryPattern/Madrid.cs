namespace AbstractFactoryPattern;

// Concrete Product B2
public class Madrid : ICapitalCity
{
    public int GetPopulation()
    {
        return 3200000;
    }

    public List<string> ListTopAttractions()
    {
        return ["Royal Palace", "Prado Museum", "El Retiro Park"];
    }
}