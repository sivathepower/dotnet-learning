using Microsoft.AspNetCore.Mvc;
using Apple;
using RepoSerDeserial.Services;
using RepoSerDeserial.Repositories;
namespace RepoSerDeserial.Controllers;

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
        return new ProductService(new ProductRepositories()).GetAllProducts();   
    }
    //read a Product
    [HttpGet("{id}", Name = "GetProductID")]
    public ActionResult<Product> GetProductId(int id)
    {
        var product = new ProductService(new ProductRepositories()).GetProductById(id);
        if (product == null)
            return NotFound();
        return product;
    }

    //Add a Product
    [HttpPost]
    public IActionResult AddProduct(Product product)
    {
        new ProductService(new ProductRepositories()).AddProduct(product);
        return CreatedAtRoute("GetProductID", new { id = product.Id }, product);
    }
    //Delete a Product
    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var product = new ProductService(new ProductRepositories()).GetProductById(id);
        if (product == null)
            return NotFound();
        new ProductService(new ProductRepositories()).DeleteProduct(id);
        return NoContent();
    }

    [HttpPut("{id}")] // Update a Product
    public IActionResult UpdateProduct(int id, Product product)
    {
        if (id != product.Id)
            return BadRequest();
        var existingProduct = new ProductService(new ProductRepositories()).GetProductById(id);
        if (existingProduct == null)
            return NotFound();
        new ProductService(new ProductRepositories()).UpdateProduct(product);
        return NoContent();
    }
}
