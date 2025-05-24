namespace FactoryPattern;

public class GooglePayPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using Google Pay");
    }
}