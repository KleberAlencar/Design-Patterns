namespace PrototypePattern._01_Approach;

public class Teacher(string name, string course) : PersonPrototype(name)
{
    public string Course { get; } = course;
    public override PersonPrototype Clone()
    {
        // shallow copy of the Person object
        return (PersonPrototype)MemberwiseClone();
    }
}