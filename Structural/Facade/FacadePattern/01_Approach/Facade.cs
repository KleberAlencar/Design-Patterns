namespace FacadePattern._01_Approach;

public class Facade
{
    protected Subsystem1 Subsystem1;
    protected Subsystem2 Subsystem2;

    public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
    {
        Subsystem1 = subsystem1;
        Subsystem2 = subsystem2;
    }

    public string Operation()
    {
        string result = "Facade initializes subsystems:\n";
        result += Subsystem1.operation1();
        result += Subsystem2.operation1();
        result += "Facade orders subsystems to perform the action:\n";
        result += Subsystem1.operationN();
        result += Subsystem2.operationZ();
        return result;
    }
}