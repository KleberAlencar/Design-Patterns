namespace TemplateMethodPattern._02_Approach;

public class ShoppingCart : OnlineShopping
{
    protected override void AddToCart()
        => Console.WriteLine("ShoppingCart says: Adding items to the cart");

    protected override void ConfirmOrder()
        => Console.WriteLine("ShoppingCart says: Order placed successfully");
}