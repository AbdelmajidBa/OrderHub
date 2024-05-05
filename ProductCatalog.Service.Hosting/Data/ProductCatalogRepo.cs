using ProductCatalog.Service.Hosting.Models;


namespace  OrderManagement.Service.Hosting.Data;


public static class ProductCatalogRepo
{
    private static List<Product> products = [];

    // Static constructor to initialize the catalog with some initial products
    static ProductCatalogRepo()
    {
        InitializeCatalog();
    }

    // Method to initialize the catalog with some initial products
    private static void InitializeCatalog()
    {
        AddProduct(new Product(1, "Smartphone", "High-end smartphone with advanced features", 999.99m, 100, "Electronics", "BrandX", DateTime.Now, DateTime.Now));
        AddProduct(new Product(2, "Laptop", "Thin and light laptop with powerful performance", 1499.99m, 50, "Electronics", "BrandY", DateTime.Now, DateTime.Now));
        AddProduct(new Product(3, "Headphones", "Noise-canceling headphones with immersive sound quality", 199.99m, 200, "Electronics", "BrandZ", DateTime.Now, DateTime.Now));
        AddProduct(new Product(4, "Camera", "Professional-grade camera for capturing high-quality photos and videos", 1299.99m, 30, "Electronics", "BrandA", DateTime.Now, DateTime.Now));
        AddProduct(new Product(5, "Television", "Ultra HD smart television with HDR support", 1999.99m, 20, "Electronics", "BrandB", DateTime.Now, DateTime.Now));
        AddProduct(new Product(6, "Tablet", "Portable tablet for entertainment and productivity", 499.99m, 80, "Electronics", "BrandC", DateTime.Now, DateTime.Now));
        AddProduct(new Product(7, "Running Shoes", "Lightweight and comfortable running shoes for athletes", 89.99m, 150, "Sports", "BrandD", DateTime.Now, DateTime.Now));
        AddProduct(new Product(8, "Backpack", "Durable backpack with multiple compartments for daily use", 39.99m, 120, "Fashion", "BrandE", DateTime.Now, DateTime.Now));
        AddProduct(new Product(9, "Cookware Set", "Premium cookware set for cooking enthusiasts", 299.99m, 40, "Home & Kitchen", "BrandF", DateTime.Now, DateTime.Now));
        AddProduct(new Product(10, "Fitness Tracker", "Activity tracker with heart rate monitoring and GPS", 149.99m, 100, "Fitness", "BrandG", DateTime.Now, DateTime.Now));
   }

    // Add a product to the catalog
    public static void AddProduct(Product product)
    {
        products.Add(product);
    }

    public static IEnumerable<Product> GetProducts()
    {
        return products;
    }
    

    // Retrieve a product by ID
    public static Product? GetProductById(int productId)
    {
        return products.Find(p => p.ProductId == productId);
    }

    // Update product information
    public static void UpdateProduct(int productId, Product updatedProduct)
    {
        var existingProduct = GetProductById(productId);
        if (existingProduct != null)
        {
            existingProduct.Name = updatedProduct.Name;
            existingProduct.Description = updatedProduct.Description;
            existingProduct.Price = updatedProduct.Price;
            existingProduct.QuantityAvailable = updatedProduct.QuantityAvailable;
            existingProduct.Category = updatedProduct.Category;
            existingProduct.Brand = updatedProduct.Brand;
            existingProduct.UpdatedAt = DateTime.Now;
        }
        else
        {
            Console.WriteLine($"Product with ID {productId} not found.");
        }
    }
}
