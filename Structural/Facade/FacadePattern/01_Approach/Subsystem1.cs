namespace FacadePattern._01_Approach;

// The Subsystem can accept requests either from the facade or client directly
// In any case, to the Subsystem, the Facade is yet another client
public class Subsystem1
{
    public string operation1() => "Subsystem1: Ready!\n";

    public string operationN() => "Subsystem1: Go!\n";
}