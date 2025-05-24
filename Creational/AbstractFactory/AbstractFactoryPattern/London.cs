namespace AbstractFactoryPattern;

// Concrete Product B1
public class London : ICapitalCity
{
    public int GetPopulation()
    {
        return 8900000;
    }

    public List<string> ListTopAttractions()
    {
        return ["Buckingham Palace", "Big Ben", "Tower Bridge", "London Eye"];
    }
}