namespace FacadePattern._02_Approach;

public class DvdPlayerSubsystem
{
    public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}.");
    public void Stop() => Console.WriteLine("DVD stopped.");
}