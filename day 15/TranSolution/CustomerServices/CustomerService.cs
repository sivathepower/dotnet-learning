namespace CustomerServices;

using CustomerEntities;
using CustomerRepository;
using System.Collections.Generic;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public IEnumerable<Customer> GetAllProducts()
    {
        return _customerRepository.GetAllProducts();
    }

    public Customer GetProductById(int id)
    {
        return _customerRepository.GetProductById(id);
    }

    public void AddProduct(Customer customer)
    {
        _customerRepository.AddProduct(customer);
    }

    public void UpdateProduct(Customer customer)
    {
        _customerRepository.UpdateProduct(customer);
    }

    public void DeleteProduct(int id)
    {
        _customerRepository.DeleteProduct(id);
    }
}
