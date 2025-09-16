namespace TransPortal.Controllers;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CustomerServices;
using CustomerRepository;
using CustomerEntities;
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
    var customers = new CustomerService(new CustomerRepository()).GetAllProducts()?.ToList() ?? new List<Customer>();
    foreach (var item in customers)
    {
        if (email == item.Email && password == item.Password)
        {
            return Redirect("/Auth/RetrieveCustomer");
        }
    }
    ViewData["Error"] = "Invalid Credentials, Please try again.";
    // TempData[_logger.LogInformation("Invalid login attempt for email: {Email}", email)];
    return View();
    }

    [HttpGet]
    public IActionResult Register()
    {

        return View();
    }
    [HttpPost]
    public IActionResult Register(string FirstName, string LastName, string Email, string Password)
    {
        Customer cust1 = new Customer(); // create a customer object
        cust1.FirstName = FirstName;
        cust1.LastName = LastName;
        cust1.Email = Email;
        cust1.Password = Password;
        var customers = new CustomerService(new CustomerRepository()).GetAllProducts()?.ToList() ?? new List<Customer>();
        cust1.Id = customers.Count + 1;
        customers.Add(cust1);
        JsonCustomerManager.SaveProducts(customers);
        return Redirect("/Auth/Login");
    }
    [HttpGet]
    public IActionResult RetrieveCustomer()
    {
        var customers = new CustomerService(new CustomerRepository()).GetAllProducts()?.ToList() ?? new List<Customer>();
        return View(customers);
    }
}
