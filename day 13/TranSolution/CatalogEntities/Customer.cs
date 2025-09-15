namespace CatalogEntities;
public class Customer
{
    public Customer() {}
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public Customer(string FirstName, string LastName, string Email ,string Password)
    {
        FirstName = FirstName;
        LastName = LastName;
        Email = Email;
        Password = Password;
    }
    public override string ToString()
    {
        return $"FirstName: {FirstName}, LastName: {LastName}, Email: {Email}";
    }
}