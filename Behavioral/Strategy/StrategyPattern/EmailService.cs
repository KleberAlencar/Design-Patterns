namespace StrategyPattern;

public class EmailService : IOrderNotifier
{
    public void NotifyOrderShipped(Order order)
    {
        var subject = $"Order {order.Id} shipped";
        var message = $"Order {order.Id} shipped at {order.ShippedAt}";
        SendEmail(subject, message);       ;
    }

    private static void SendEmail(string subject, string message)
    {
        Console.WriteLine($"Email sent\n{subject}\n{message}");
    }
}