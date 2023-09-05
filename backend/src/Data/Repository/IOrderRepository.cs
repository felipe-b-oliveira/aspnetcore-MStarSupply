using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MStarSupply.Enums;
using MStarSupply.Models;

namespace MStarSupply.Data;
public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllOrdersAsync();
    Task<Order> GetOrderByIdAsync(Guid orderId);
    Task AddOrderAsync(Order order);
    Task UpdateOrderAsync(Order order);
    // Task DeleteOrderAsync(Guid orderId);
}
