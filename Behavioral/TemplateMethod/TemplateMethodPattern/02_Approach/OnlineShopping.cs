namespace TemplateMethodPattern._02_Approach;

public abstract class OnlineShopping
{
    // Abstract Class defines a template method that contains a skeleton of some algorithm
    public void PlaceOrder()
    {
        Login();
        AddToCart();
        MakePayment();
        ConfirmOrder();
    }
    
    // These operations SHOULD be implemented in subclasses
    protected virtual void Login() 
        => Console.WriteLine("OnlineShopping says: Logging in to the online store");
    
    protected virtual void MakePayment() 
        => Console.WriteLine("OnlineShopping says: Making payment");

    // These operations HAVE to be implemented in subclasses
    protected abstract void AddToCart();
    
    protected abstract void ConfirmOrder();
}