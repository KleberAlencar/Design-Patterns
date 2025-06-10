using FacadePattern._01_Approach;
using FacadePattern._02_Approach;

Console.WriteLine("01_Approach Facade Pattern =================");
Console.WriteLine(" ");

Subsystem1 subsystem1 = new Subsystem1();
Subsystem2 subsystem2 = new Subsystem2();
Facade facade = new Facade(subsystem1, subsystem2);
Client.ClientCode(facade);

Console.WriteLine(" ");

Console.WriteLine("02_Approach Facade Pattern =================");
Console.WriteLine(" ");

var amplifier = new AmplifierSubsystem();
var dvdPlayer = new DvdPlayerSubsystem();
var project = new ProjectorSubsystem();

var homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, project);

homeTheater.WatchMovie("Inception");
homeTheater.EndMovie();
