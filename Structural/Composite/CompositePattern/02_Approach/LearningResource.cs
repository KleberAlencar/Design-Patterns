namespace CompositePattern._02_Approach;

// Component class for the Composite Pattern
public abstract class LearningResource()
{
    public abstract string GetName();
    public abstract decimal GetPrice();
    public abstract TimeSpan GetDuration();

    public virtual void Add(LearningResource learningResource)
    {
    }

    public virtual void Remove(LearningResource learningResource)
    {
    }

    public virtual LearningResource? GetLearningResource(string name)
    {
        return null;
    }
}