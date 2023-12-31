namespace MStarSupply.Models;

public class Product
{
    public Guid ProductId { get; set; }

    public string Name { get; set; }

    public string Manufacturer { get; set; }

    public string Type { get; set; }

    public int Amount { get; set; }

    public string Description { get; set; }

    /* EF Relations */
    public ICollection<OrderProduct> OrderProducts { get; set; }
}