namespace CustomerServices;

using CustomerEntities;
using System.Collections.Generic;
public interface ICustomerService
{
    IEnumerable<Customer> GetAllProducts();
    Customer GetProductById(int id);
    void AddProduct(Customer customer);
    void UpdateProduct(Customer customer);
    void DeleteProduct(int id);
}