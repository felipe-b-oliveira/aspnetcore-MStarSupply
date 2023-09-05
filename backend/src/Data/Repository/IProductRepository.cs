using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MStarSupply.Models;

namespace MStarSupply.Data;

/*
 * IProductRepository: Define os métodos a serem implementados pelo ORM de acordo com as regras de negócio.
 * TODO: Refatorar para Business/Interfaces
 */
public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task<Product> GetProductByIdAsync(Guid productId);
    Task AddProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(Guid productId);
}
