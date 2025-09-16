namespace CustomerRepository;
using CustomerEntities;
using System.Collections.Generic;
public interface ICustomerRepository
{
    IEnumerable<Customer> GetAllProducts();
    Customer GetProductById(int id);
    void AddProduct(Customer product);
    void UpdateProduct(Customer product);
    void DeleteProduct(int id);
}