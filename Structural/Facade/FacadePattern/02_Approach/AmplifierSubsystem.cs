namespace FacadePattern._02_Approach;

public class AmplifierSubsystem
{
    public void On() => Console.WriteLine("Amplifier is ON.");
    public void SetVolume(int level) => Console.WriteLine($"Volume set to {level}.");
}