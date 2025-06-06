namespace StrategyPattern._01_Approach;

public class OrderService(IOrderNotifier notifier)
{
    public void ShipOrder(Order order)
    {
        notifier.NotifyOrderShipped(order);
    }
}