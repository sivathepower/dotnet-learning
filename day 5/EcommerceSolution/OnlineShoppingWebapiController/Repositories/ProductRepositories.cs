using OnlineShoppingWebapiController.Repositories;

namespace OnlineShoppingWebapiController.Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99m, Description = "A high-performance laptop." },
            new Product { Id = 2, Name = "Smartphone", Price = 499.99m, Description = "A latest model smartphone." },
            new Product { Id = 3, Name = "Headphones", Price = 199.99m, Description = "Noise-cancelling headphones." }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = GetProductById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Description = product.Description;
            }
        }

        public void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}