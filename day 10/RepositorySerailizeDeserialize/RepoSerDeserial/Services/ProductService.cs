using RepoSerDeserial.Services;
using RepoSerDeserial.Repositories;
using Apple;
namespace RepoSerDeserial.Services;
public class ProductService : IProductService
{
    private readonly IProductRepositories _productRepositories;

    public ProductService(IProductRepositories productRepositories)
    {
        _productRepositories = productRepositories;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _productRepositories.GetAllProducts();
    }

    public Product GetProductById(int id)
    {
        return _productRepositories.GetProductById(id);
    }

    public void AddProduct(Product product)
    {
        _productRepositories.AddProduct(product);
    }

    public void UpdateProduct(Product product)
    {
        _productRepositories.UpdateProduct(product);
    }

    public void DeleteProduct(int id)
    {
        _productRepositories.DeleteProduct(id);
    }
}
