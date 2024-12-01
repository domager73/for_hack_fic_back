using for_hack_fic.Db.Models;
using for_hack_fic.Models;
using for_hack_fic.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace for_hack_fic.Controllers;

[ApiController]
[Route("product/")]
public class ProductController : ControllerBase
{
    private readonly ProductRepository _productRepository;

    public ProductController(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet("get-all")]
    public List<Product> GetAllProducts()
    {
        return _productRepository.GetAll();
    }
    
    [HttpPost("get-filtered")]
    public List<Product> GetFilteredProducts(ProductFilter productFilter)
    {
        return _productRepository.GetFilteredProducts(productFilter);
    }
}