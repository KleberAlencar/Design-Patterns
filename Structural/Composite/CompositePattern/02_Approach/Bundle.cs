namespace CompositePattern._02_Approach;

// Composite Pattern
public class Bundle(string name) : LearningResource()
{
    private readonly List<LearningResource> _children = [];
    
    public override string GetName()
    {
        return name;
    }

    public override decimal GetPrice()
    {
        return _children.Sum(x => x.GetPrice() * 0.8m); // 20% discount for bundles
    }

    public override TimeSpan GetDuration()
    {
        return new(_children.Sum(x => x.GetDuration().Ticks));
    }
    
    public override void Add(LearningResource learningResource)
    {
        _children.Add(learningResource);
    }

    public override void Remove(LearningResource learningResource)
    {
        _children.Remove(learningResource);
    }
    
    public override LearningResource? GetLearningResource(string name)
    {
        return _children.SingleOrDefault(x => x.GetName() == name);
    }
}