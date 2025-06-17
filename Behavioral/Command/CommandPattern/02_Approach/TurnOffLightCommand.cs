namespace CommandPattern._02_Approach;

public class TurnOffLightCommand(Light light) : ICommand
{
    public void Execute() => light.TurnOff();
    public void Undo() => light.TurnOn();
}