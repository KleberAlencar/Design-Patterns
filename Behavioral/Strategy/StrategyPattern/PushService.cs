namespace StrategyPattern;

public class PushService : IOrderNotifier
{
    public void NotifyOrderShipped(Order order)
    {
        var message = $"Order {order.Id} shipped at {order.ShippedAt}";
        SendPush(message);                  
    }
    
    private static void SendPush(string message)
    {
        Console.WriteLine($"Push sent - {message}");
    }
}