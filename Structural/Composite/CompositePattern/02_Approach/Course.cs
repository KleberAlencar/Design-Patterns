namespace CompositePattern._02_Approach;

// Leaf class for the Composite Pattern
public class Course(string name, TimeSpan duration, decimal price) : LearningResource()
{
    public override string GetName()
    {
        return name;
    }

    public override decimal GetPrice()
    {
        return price;
    }

    public override TimeSpan GetDuration()
    {
        return duration;
    }
}