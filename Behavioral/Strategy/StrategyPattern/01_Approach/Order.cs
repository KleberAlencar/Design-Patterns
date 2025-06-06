using StrategyPattern._01_Approach.Enums;

namespace StrategyPattern._01_Approach;

public record Order()
{
    private Order(EOrderStatus status) : this()
    {
        Status = status;       
    }
    
    public Guid Id  { get; private set; }
    public EOrderStatus Status { get; private set; }
    public DateTime ShippedAt { get; private set; }

    public static Order Create(EOrderStatus status)
    {
        var order = new Order(status)
        {
            Id = Guid.CreateVersion7(),
            ShippedAt = DateTime.UtcNow
        };
        return order;       
    }
}