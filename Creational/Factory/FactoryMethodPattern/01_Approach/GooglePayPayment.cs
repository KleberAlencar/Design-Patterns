namespace FactoryPattern._01_Approach;

public class GooglePayPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using Google Pay");
    }
}