namespace CRM;

public class Customer : IComparable<Customer>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Customer(int id, string name, int age = 0)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Age: {Age}";
    }
    public int CompareTo(Customer? other)
    {
        if (other == null) return 1;

        // return this.Id.CompareTo(other.Id);
        return this.Name.CompareTo(other.Name);
    }
}   