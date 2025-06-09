using TemplateMethodPattern._01_Approach;
using TemplateMethodPattern._02_Approach;

Console.WriteLine("01_Approach Template Method Pattern ========");
Console.WriteLine(" ");

Console.WriteLine("Same client code can work with different subclasses:");

Client.ClientCode(new ConcreteClass1());

Console.Write("\n");
            
Console.WriteLine("Same client code can work with different subclasses:");
Client.ClientCode(new ConcreteClass2());

Console.WriteLine(" ");

Console.WriteLine("02_Approach Template Method Pattern ========");
Console.WriteLine(" ");

ShoppingCart shoppingCart = new ShoppingCart();
BuyNow buyNow = new BuyNow();

Console.WriteLine("Placing Order via Shopping Cart");
shoppingCart.PlaceOrder();

Console.WriteLine(" ");

Console.WriteLine("Placing Order via Buy Now");
buyNow.PlaceOrder();