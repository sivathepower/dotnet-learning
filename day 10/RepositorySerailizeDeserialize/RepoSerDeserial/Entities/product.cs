namespace Apple;


public class Product
{
    public Product() {}
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Product(int Id, string Name, string Description ,double price)
    {
        Id = Id;
        Name = Name;
        Description = Description;
        Price = price;
    }
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Price: {Price}";
    }
}