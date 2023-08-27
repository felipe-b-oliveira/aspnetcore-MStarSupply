namespace MStarSupply.Models;

public class OrderProduct
{
    public Guid OrderProductId { get; set; }

    public Guid ProductId { get; set; }

    public Product Product { get; set; }

    public Guid OrderId { get; set; }

    public Order Order { get; set; }

    public int TransactionAmount { get; set; }

    public DateTime TransactionDate { get; set; }
}