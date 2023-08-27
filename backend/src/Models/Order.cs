using MStarSupply.Enums;

namespace MStarSupply.Models;

public class Order
{
    public Guid OrderId { get; set; }

    public DateTime Date { get; set; }

    public string Location { get; set; }

    public OrderTypeEnum OrderType { get; set; }

    /* EF Relations */
    public ICollection<OrderProduct> OrderProducts { get; set; }
}