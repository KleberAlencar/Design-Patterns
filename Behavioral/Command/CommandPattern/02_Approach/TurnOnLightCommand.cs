namespace CommandPattern._02_Approach;

public class TurnOnLightCommand(Light light) : ICommand
{
    public void Execute() => light.TurnOn();
    public void Undo() => light.TurnOff();
}
