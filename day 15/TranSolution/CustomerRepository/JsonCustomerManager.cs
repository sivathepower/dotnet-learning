namespace CustomerRepository;

using CustomerEntities;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// any class to be helper class , need to be static class
public static class JsonCustomerManager
{
    private static string getFilePath()
    {
        string filePath = @"C:\dotnet learning\MyconsoleApp\day 13\TranSolution\Data\Customers.json";
        return filePath;
    }

    public static IEnumerable<Customer>? LoadProducts()
    {
        var json = File.ReadAllText(getFilePath());
        return JsonSerializer.Deserialize<IEnumerable<Customer>>(json);
    }
    public static void SaveProducts(IEnumerable<Customer> customers)
    {
        var json = JsonSerializer.Serialize(customers);
        File.WriteAllText(getFilePath(), json);
    }
}