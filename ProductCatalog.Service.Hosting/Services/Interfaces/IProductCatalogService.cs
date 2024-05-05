using ProductCatalog.Service.Hosting.Models;

namespace ProductCatalog.Service.Hosting.Services.Interfaces;

public interface IProductCatalogService
{
    Task CreateProduct(Product product);
    IEnumerable<Product> GetProducts();
}