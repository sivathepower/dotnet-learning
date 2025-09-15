namespace CatalogRepository;

using CatalogEntities;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// any class to be helper class , need to be static class
public static class JsonCatalogManager
{
    // private static readonly string filePath = @"C:\dotnet learning\MyconsoleApp\day 13\TranSolution\Data\Products.json";

    private static string getFilePath()
    {
        // string path = Directory.GetCurrentDirectory();
        // string filePath = Path.Combine(path, "Data", "Products.json");
        // Console.WriteLine(filePath);
        string filePath = @"C:\dotnet learning\MyconsoleApp\day 13\TranSolution\Data\Products.json";
        return filePath;
    }

    public static IEnumerable<Product>? LoadProducts()
    {
        var json = File.ReadAllText(getFilePath());
        return JsonSerializer.Deserialize<IEnumerable<Product>>(json);
    }
    public static void SaveProducts(IEnumerable<Product> products)
    {
        var json = JsonSerializer.Serialize(products);
        File.WriteAllText(getFilePath(), json);
    }
}