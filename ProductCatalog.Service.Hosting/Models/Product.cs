namespace ProductCatalog.Service.Hosting.Models;

public class Product
{
     public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int QuantityAvailable { get; set; }
    public string Category { get; set; }
    public string Brand { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    // Constructor
    public Product(int productId, string name, string description, decimal price, int quantityAvailable,
                   string category, string brand, DateTime createdAt, DateTime updatedAt)
    {
        ProductId = productId;
        Name = name;
        Description = description;
        Price = price;
        QuantityAvailable = quantityAvailable;
        Category = category;
        Brand = brand;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

}