namespace MStarSupply.Models;

public class TransactionModel
{
    public Guid TransactionId { get; set; }

    public Guid ProductId { get; set; }

    public ProductModel Product { get; set; }

    public Guid OrderId { get; set; }

    public OrderModel Order { get; set; }

    public int TransactionAmount { get; set; }
}