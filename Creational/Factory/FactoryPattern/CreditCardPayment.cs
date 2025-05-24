namespace FactoryPattern;

public class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using credit card");
    }
}