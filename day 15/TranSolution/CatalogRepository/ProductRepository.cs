namespace CatalogRepository;

using CatalogEntities;
using System.Collections.Generic;   
using System.IO;
using System.Text.Json;
public class ProductRepository : IProductRepository
{
    //automic operations
    public IEnumerable<Product>? GetAllProducts()
    {
        return JsonCatalogManager.LoadProducts();
    }


    public Product? GetProductById(int id)
    {
        IEnumerable<Product> products = GetAllProducts();
        return products.FirstOrDefault(p => p.Id == id);
    }

    public void AddProduct(Product product)
    {
        List<Product> products = GetAllProducts().ToList();
        products.Add(product);
        JsonCatalogManager.SaveProducts(products);
    }

    public void UpdateProduct(Product product)
    {
        
        List<Product> products = GetAllProducts().ToList();
        var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
        if (existingProduct != null)
        {
            existingProduct.Title = product.Title;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.ImageUrl = product.ImageUrl;
            JsonCatalogManager.SaveProducts(products);
        }
    }

    public void DeleteProduct(int id)
    {
        List<Product> products = GetAllProducts().ToList();
        var productToRemove = products.FirstOrDefault(p => p.Id == id);
        if (productToRemove != null)
        {
            products.Remove(productToRemove);
            JsonCatalogManager.SaveProducts(products);
        }
    }
}
