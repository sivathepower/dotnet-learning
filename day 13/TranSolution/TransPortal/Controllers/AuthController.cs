
namespace TransPortal.Controllers;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CatalogServices;
using CatalogRepository;
using CatalogEntities;
using System.Text.Json;
using System.IO;

public class AuthController : Controller
{
    private readonly ILogger<ProductController> _logger;
    public AuthController(
        ILogger<ProductController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        List<Customer> customers = new List<Customer>();
        string jsonString = System.IO.File.ReadAllText(@"C:\dotnet learning\MyconsoleApp\day 13\TranSolution\Data\Customers.json");
        customers = JsonSerializer.Deserialize<List<Customer>>(jsonString);
        foreach (var item in customers)
        {
            if (email == item.Email && password == item.Password)
            {
                this.Response.Redirect("/Product");
            }
            else
            {
                ViewData["Error"] = "Invalid Credentials, Please try again.";
            }
        }
        return View();
    }

    [HttpGet]
    public IActionResult Register()
    {

        return View();
    }
    [HttpPost]
    public IActionResult Register( string FirstName, string LastName, string Email, string Password)
    {
        Customer cust1 = new Customer(); // create a customer object
        cust1.FirstName = FirstName;
        cust1.LastName = LastName;
        cust1.Email = Email;
        cust1.Password = Password;
        string deserialization = System.IO.File.ReadAllText(@"C:\dotnet learning\MyconsoleApp\day 13\TranSolution\Data\Customers.json");
        List<Customer> customers = JsonSerializer.Deserialize<List<Customer>>(deserialization);
        customers.Add(cust1);
        string jsonString = JsonSerializer.Serialize(customers);  // serialize the object to JSON string
        Console.WriteLine(jsonString);
        System.IO.File.WriteAllText(@"C:\dotnet learning\MyconsoleApp\day 13\TranSolution\Data\Customers.json", jsonString);
        return Redirect("/Auth/Login");
    }
}
