namespace StrategyPattern._01_Approach;

public class PostalService : IOrderNotifier
{
    public void NotifyOrderShipped(Order order)
    {
        var message = $"Order {order.Id} shipped at {order.ShippedAt}";
        SendPostal(message);       
    }
    
    private static void SendPostal(string message)
    {
        Console.WriteLine($"Postal sent - {message}");
    }
}