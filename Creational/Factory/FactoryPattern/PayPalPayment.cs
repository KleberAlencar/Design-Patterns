namespace FactoryPattern;

public class PayPalPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using PayPal");
    }
}