using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Service.Hosting.Models;
using ProductCatalog.Service.Hosting.Services.Interfaces;

namespace ProductCatalog.Service.Hosting.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductCatalogController : ControllerBase
{    
    private readonly ILogger<ProductCatalogController> _logger;
    private readonly IProductCatalogService _productCatalogService;
    public ProductCatalogController(IProductCatalogService productCatalogService, ILogger<ProductCatalogController> logger)
    {
        _logger = logger;
        _productCatalogService =productCatalogService;
    }

    [HttpGet(Name = "GetProductsCatalog")]
    public IEnumerable<Product> Get()
    {
        return _productCatalogService.GetProducts();
    }
}
