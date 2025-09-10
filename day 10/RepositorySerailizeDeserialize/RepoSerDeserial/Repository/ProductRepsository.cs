using RepoSerDeserial.Repositories;
using Apple;
using System.IO;
using System.Text.Json;
namespace RepoSerDeserial.Repositories;
public class ProductRepositories : IProductRepositories
{
    private readonly List<Product> _products;
    private List<Product> deserializedProducts;

    public ProductRepositories()
    {
        _products = new List<Product>();
        string jsonFromFile = System.IO.File.ReadAllText("products.json");
        deserializedProducts = JsonSerializer.Deserialize<List<Product>>(jsonFromFile);
    }

    public IEnumerable<Product> GetAllProducts()
    {
    //    Product product1 = new Product() { Id = 1, Name = "apple 16", Description = "Description 1", Price = 100000 };
    //     Product product2 = new Product() { Id = 2, Name = "apple 17", Description = "Description 2", Price = 200000 };
    //     List<Product> products = new List<Product>();
    //     products.Add(product1);
    //     products.Add(product2);
    //     string jsonString = JsonSerializer.Serialize(products);
    //     System.IO.File.WriteAllText("products.json", jsonString);
        // string jsonFromFile = System.IO.File.ReadAllText("products.json");
        // List<Product> deserializedProducts = JsonSerializer.Deserialize<List<Product>>(jsonFromFile);
        // Console.WriteLine("Deserialized Products:");
        // foreach (var prod in deserializedProducts)
        // {
        //     Console.WriteLine(prod);
        // }

        return deserializedProducts;
        // return _products;
    }

    public Product GetProductById(int id)
    {
        // return _products.FirstOrDefault(p => p.Id == id);
        return deserializedProducts.FirstOrDefault(p => p.Id == id);
    }

    public void AddProduct(Product product)
    {
        deserializedProducts.Add(product);
        string jsonString = JsonSerializer.Serialize(deserializedProducts);
        System.IO.File.WriteAllText("products.json", jsonString);
    }

    public void UpdateProduct(Product product)
    {
        var existingProduct = GetProductById(product.Id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            string jsonString = JsonSerializer.Serialize(deserializedProducts);
            System.IO.File.WriteAllText("products.json", jsonString);
        }
    }

    public void DeleteProduct(int id)
    {
        var product = GetProductById(id);
        if (product != null)
        {
            deserializedProducts.Remove(product);
            string jsonString = JsonSerializer.Serialize(deserializedProducts);
            System.IO.File.WriteAllText("products.json", jsonString);
        }
    }
}

