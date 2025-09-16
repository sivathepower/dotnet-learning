namespace CustomerRepository;

using CustomerEntities;
using System.Collections.Generic;   
using System.IO;
using System.Text.Json;
public class CustomerRepository : ICustomerRepository
{
    //automic operations
    public IEnumerable<Customer>? GetAllProducts()
    {
        return JsonCustomerManager.LoadProducts();
    }


    public Customer? GetProductById(int id)
    {
        IEnumerable<Customer> customers = GetAllProducts();
        return customers.FirstOrDefault(p => p.Id == id);
    }

    public void AddProduct(Customer customer)
    {
        List<Customer> customers = GetAllProducts().ToList();
        customers.Add(customer);
        JsonCustomerManager.SaveProducts(customers);
    }

    public void UpdateProduct(Customer customer)
    {
        
        List<Customer> customers = GetAllProducts().ToList();
        var existingCustomer = customers.FirstOrDefault(p => p.Id == customer.Id);
        if (existingCustomer != null)
        {
            existingCustomer.FirstName = customer.FirstName;
            existingCustomer.LastName = customer.LastName;
            existingCustomer.Email = customer.Email;
            existingCustomer.Password = customer.Password;
            existingCustomer.Id = customer.Id;
            JsonCustomerManager.SaveProducts(customers);
        }
    }

    public void DeleteProduct(int id)
    {
        List<Customer> customers = GetAllProducts().ToList();
        var customerToRemove = customers.FirstOrDefault(p => p.Id == id);
        if (customerToRemove != null)
        {
            customers.Remove(customerToRemove);
            JsonCustomerManager.SaveProducts(customers);
        }
    }
}
