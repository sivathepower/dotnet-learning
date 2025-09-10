using CRM;
using System; //   Array,List,Dictionary
using System.Text.Json; // serialization and deserialization
using System.IO; // for file operations
int number = 10;
// string text = "The number is: ";
// Console.WriteLine(number);

// int[] numbers = { 10, 2, 36, 48, 5 };
// string[] texts = { "one", "two", "three" };
// Console.WriteLine(numbers[0]);
// Console.WriteLine(texts[0]);
// foreach (var item in numbers)
// {
//     Console.WriteLine(item);
// }

// //matrix -2d array   -> balanced array
// int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         Console.WriteLine(matrix[i, j]);
//     }
// }

// //jagged array -> unbalanced array
// int[][] jaggedArray = new int[2][]; //array of arrays
// jaggedArray[0] = new int[] { 1, 2 };
// jaggedArray[1] = new int[] { 3, 4, 5 };
// for (int i = 0; i < jaggedArray.Length; i++)
// {
//     for (int j = 0; j < jaggedArray[i].Length; j++)
//     {
//         Console.WriteLine(jaggedArray[i][j]);
//     }
// }

// Array.Sort(numbers);
// Console.WriteLine("Sorted numbers:");
// foreach (var item in numbers)
// {
//     Console.WriteLine(item);
// }

Customer customer1 = new Customer(1, "Johntp");
Customer customer2 = new Customer(20, "Jane");
Customer customer3 = new Customer(3, "Janekp");
Customer customer4 = new Customer(22, "Janejj");
List<Customer> customers = new List<Customer>();
customers.Add(customer1);
customers.Add(customer2);
customers.Add(customer3);
customers.Add(customer4);

// Array.Sort(customers?.ToArray());
customers.Sort(); // uses CompareTo method internally, uses Icomparable interface implementation of customer class
Console.WriteLine("Sorted customers by Id:");
foreach (var item in customers)
{
    Console.WriteLine(item);
}

//Dictionary just like map in javascript
// Dictionary<int, string> dict = new Dictionary<int, string>();
Dictionary<String,Customer> customersDictionary = new Dictionary<String,Customer>();
customersDictionary.Add("22",new Customer(1, "Johntp"));
customersDictionary.Add("29",new Customer(20, "Jane"));
customersDictionary.Add("21",new Customer(3, "Janekp"));
customersDictionary.Add("20",new Customer(22, "Janejj"));
//customersDictionary.Sort(); // uses CompareTo method internally, uses Icomparable interface implementation of customer class
Console.WriteLine("Sorted customersDictionary by Id:");
foreach (var item in customersDictionary)
{
    Console.WriteLine(item);
}


//serialization AND deserialization
Customer cust1 = new Customer(101, "John", 30); // create a customer object
string jsonString = JsonSerializer.Serialize(cust1);  // serialize the object to JSON string
// JsonSerializer is a helper class with static methods
Console.WriteLine("Serialized JSON: " + jsonString);

// to save serialzed data to a file
// File.WriteAllText("customer.json", jsonString); // write the JSON string to a file
File.WriteAllText("customer.json", jsonString);

// to read from a file and deserialize      
string jsonFromFile = File.ReadAllText("customer.json"); // read the JSON string from the file
Customer deserializedCust = JsonSerializer.Deserialize<Customer>(jsonString); // deserialize the JSON string back to a Customer object
Console.WriteLine("Deserialized Customer: " + deserializedCust);