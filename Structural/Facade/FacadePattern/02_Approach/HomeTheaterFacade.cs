namespace FacadePattern._02_Approach;

public class HomeTheaterFacade
{
    private readonly AmplifierSubsystem _amplifierSubsystem;
    private readonly DvdPlayerSubsystem _dvdPlayerSubsystem;
    private readonly ProjectorSubsystem _projectorSubsystem;

    public HomeTheaterFacade(
        AmplifierSubsystem amplifierSubsystem, 
        DvdPlayerSubsystem dvdPlayerSubsystem, 
        ProjectorSubsystem projectorSubsystem)
    {
        _amplifierSubsystem = amplifierSubsystem;
        _dvdPlayerSubsystem = dvdPlayerSubsystem;
        _projectorSubsystem = projectorSubsystem;
    }
    
    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        _amplifierSubsystem.On();
        _amplifierSubsystem.SetVolume(10);
        _projectorSubsystem.On();
        _projectorSubsystem.SetWideScreenMode();
        _dvdPlayerSubsystem.Play(movie);
    }
    
    public void EndMovie()
    {
        Console.WriteLine("Shutting down the home theater...");
        _dvdPlayerSubsystem.Stop();
        Console.WriteLine("Goodbye!");
    }
}