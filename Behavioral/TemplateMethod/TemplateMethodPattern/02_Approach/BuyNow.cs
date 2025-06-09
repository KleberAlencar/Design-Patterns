namespace TemplateMethodPattern._02_Approach;

public class BuyNow : OnlineShopping
{
    protected override void AddToCart() 
        => Console.WriteLine("BuyNow says: Adding items to the cart");

    protected override void ConfirmOrder() 
        => Console.WriteLine("BuyNow says: Order placed successfully");
}