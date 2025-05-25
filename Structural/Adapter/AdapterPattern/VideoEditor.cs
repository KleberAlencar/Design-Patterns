namespace AdapterPattern;

public class VideoEditor(IVideo video)
{
    public void ApplyColor(IColor color)
    {
        color.Apply(video);
    }
} 