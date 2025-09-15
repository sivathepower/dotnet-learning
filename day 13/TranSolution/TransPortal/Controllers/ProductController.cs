
namespace TransPortal.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CatalogServices;
using CatalogRepository;
using CatalogEntities;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;
    public ProductController(
        ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
    var products = new ProductService(new ProductRepository()).GetAllProducts();
    return View(products);
    }
}   