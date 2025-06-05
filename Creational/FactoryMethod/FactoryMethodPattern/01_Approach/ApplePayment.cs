namespace FactoryMethodPattern._01_Approach;

public class ApplePayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using Apple Pay");
    }
}