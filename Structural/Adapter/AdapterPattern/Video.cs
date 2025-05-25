namespace AdapterPattern;

public class Video : IVideo
{
    public void Generate()
    {
        Console.WriteLine("Video generated");
    }    
}