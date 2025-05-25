namespace StrategyPattern;

public interface IOrderNotifier
{
    void NotifyOrderShipped(Order order);
}