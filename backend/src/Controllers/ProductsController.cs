using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MStarSupply.Models;

namespace MStarSupply.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        // MOCK Inicial
        string minhaString = "OK";
        IEnumerable<Product> minhaColecao = new List<Product>

        {
            new Product
            {
            Name = minhaString,
            }
        };

        return minhaColecao;
    }
}