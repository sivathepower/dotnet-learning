using Microsoft.AspNetCore.Mvc;
using Catalog;
namespace OnlineShoppingWebapiController.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProduct")]
    public IEnumerable<Product> Get()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Description = "Description 1", Price = 10.0m },
            new Product { Id = 2, Name = "Product 2", Description = "Description 2", Price = 20.0m }
        };
    }
}
