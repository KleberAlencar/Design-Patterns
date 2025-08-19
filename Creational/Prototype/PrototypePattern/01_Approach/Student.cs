namespace PrototypePattern._01_Approach;

public class Student(string name, Teacher teacher) : PersonPrototype(name)
{
    public Teacher Teacher { get; private set; } = teacher;
    
    public override PersonPrototype Clone()
    {
        // deep copy of the Person object
        Student studentClone = (Student)MemberwiseClone();
        studentClone.Teacher = new(Teacher.Name, Teacher.Course);
        return studentClone;
    }
}