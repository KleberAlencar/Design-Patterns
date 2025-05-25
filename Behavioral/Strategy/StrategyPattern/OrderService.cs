using StrategyPattern.Enums;

namespace StrategyPattern;

public class OrderService(IOrderNotifier notifier)
{
    public void ShipOrder(Order order)
    {
        notifier.NotifyOrderShipped(order);
    }
}