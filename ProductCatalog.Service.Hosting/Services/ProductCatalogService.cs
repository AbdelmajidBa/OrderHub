using ProductCatalog.Service.Hosting.Models;
using OrderManagement.Service.Hosting.Data;
using ProductCatalog.Service.Hosting.Services.Interfaces;

namespace ProductCatalog.Service.Hosting.Services;

public class ProductCatalogService : IProductCatalogService
{
    public Task CreateProduct(Product product)
    {
        ProductCatalogRepo.AddProduct(product);
        return Task.CompletedTask;
    }
    public IEnumerable<Product> GetProducts()
    {
        return ProductCatalogRepo.GetProducts();
    }
}

