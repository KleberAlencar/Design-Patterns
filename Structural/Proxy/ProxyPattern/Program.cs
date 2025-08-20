using ProxyPattern._01_Approach;
using ProxyPattern._02_Approach;

Console.WriteLine("01_Approach Proxy Pattern =================");
Console.WriteLine(" ");

Proxy proxy = new Proxy();
proxy.Operation();
proxy.Operation();
proxy.Operation();

Console.WriteLine("02_Approach Proxy Pattern =================");
Console.WriteLine(" ");

Console.WriteLine(" ");

IImage image1 = new ProxyImage(fileName: "image1");
IImage image2 = new ProxyImage(fileName: "image2");

Console.WriteLine("Displaying image 1");
image1.Display();

Console.WriteLine("Displaying image 2");
image2.Display();

Console.WriteLine("Displaying image 1 again");
image1.Display();

Console.WriteLine("Displaying image 1 again");
image1.Display();

Console.WriteLine("Displaying image 1 again");
image1.Display();