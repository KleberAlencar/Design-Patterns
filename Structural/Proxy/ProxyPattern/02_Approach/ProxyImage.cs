namespace ProxyPattern._02_Approach;

public class ProxyImage : IImage
{
    private RealImage? _realImage = null;
    private readonly string _filename;

    public ProxyImage(string fileName)
    {
        Console.WriteLine("Instantiating proxy");
        _filename = fileName;
    }

    public void Display()
    {
        Console.WriteLine("Performing operation in proxy");

        if (_realImage is null)
        {
            Console.WriteLine("Showing low resolution placeholder:");
            Console.WriteLine(
                """
                          ...::..
                        .--:. : :.-
                      .-~. : : -.: -.
                     .:  : 0 ..0. :  :.
                    .. . .. .. .  . ..
                    -:~..-.:----..-.:-
                   ~~-~- : ::::::-.~:~~
                    .. . :...:....:. ..
                     ~.....:   --...:~
                   ....::::|::|::...::
                    ......:|::|::::...
                     -........:-~~~~~
                      ::.............
                    . -  ::.::.  ::-.
                """);
            _realImage = new RealImage(_filename);
            return;
        }

        _realImage.Display();
    }  
}