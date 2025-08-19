// client code
using CompositePattern._01_Approach;
using CompositePattern._02_Approach;

Console.WriteLine("01_Approach Composite Pattern ================");
Console.WriteLine(" ");

Component root = new Composite("Root Composite");

Component leafA = new Leaf("Leaf A");
root.Add(leafA);

Component childComposite = new Composite("Child Composite");
Component leafB = new Leaf("Leaf B");
Component leafC = new Leaf("Leaf C");

childComposite.Add(leafB);
childComposite.Add(leafC);

root.Add(childComposite);

root.Operation();

Console.WriteLine(" ");

Console.WriteLine("02_Approach Composite Pattern ================");
Console.WriteLine(" ");

LearningResource bundle = new Bundle(name: "Zero to Hero: Clean Architecture");

LearningResource courseA = new Course(
    name: "Getting Started: Clean Architecture",
    duration: TimeSpan.FromHours(3),
    price: 100);

LearningResource courseB = new Course(
    name: "Deep Dive: Clean Architecture",
    duration: TimeSpan.FromHours(4),
    price: 110);
    
bundle.Add(courseA);
bundle.Add(courseB);

Console.WriteLine(bundle.GetPrice());    