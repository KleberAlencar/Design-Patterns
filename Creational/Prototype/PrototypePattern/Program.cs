using PrototypePattern._01_Approach;
using PrototypePattern._02_Approach;

Console.WriteLine("01_Approach Prototype Pattern ================");
Console.WriteLine(" ");

Teacher teacher = new("Kleber", "Creational Design Patterns in C#");
Teacher teacherClone = (Teacher)teacher.Clone();
Console.WriteLine($"Teacher was cloned: {teacherClone.Name}, Course: {teacherClone.Course}");

Student student = new("John", teacherClone);
Student studentClone = (Student)student.Clone();
Console.WriteLine($"Student was cloned: {studentClone.Name} who is enrolled in {studentClone.Teacher.Name}'s course.");

// Change the original teacher's name
teacherClone.Name = "Paul";
Console.WriteLine($"Student was cloned: {studentClone.Name} who is enrolled in {studentClone.Teacher.Name}'s course.");

Console.WriteLine(" ");

Console.WriteLine("02_Approach Prototype Pattern ================");
Console.WriteLine(" ");

var rectangle = new Rectangle(width: 100, height: 100, Color.LightGray, "Rectangle");
Console.WriteLine($"Shape cloned with width: {rectangle.Name}");

var rectangleClone = rectangle.Clone();
rectangleClone.Name = "Rectangle Clone";
Console.WriteLine($"Shape cloned with width: {rectangleClone.Name}");

var circle = new Circle(radius: 50, Color.LightGray, "Circle");
Console.WriteLine($"Shape cloned with width: {circle.Name}");

var circleClone = circle.Clone();
circleClone.Name = "Circle Clone";
Console.WriteLine($"Shape cloned with width: {circleClone.Name}");
