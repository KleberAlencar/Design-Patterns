namespace StrategyPattern._01_Approach;

public class SmsService : IOrderNotifier
{
    public void NotifyOrderShipped(Order order)
    {
        var message = $"Order {order.Id} shipped at {order.ShippedAt}";
        SendSms(message);       
    }

    private static void SendSms(string message)
    {
        Console.WriteLine($"SMS sent - {message}");
    }
}