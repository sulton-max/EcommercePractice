using ECommerce.Api.Models.Entities;
using ECommerce.Api.Services.Products;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductsService _productsService;

    public ProductsController(IProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        var result = _productsService.GetAll();
        return result.Any() ? Ok(result) : NotFound();
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetProduct(Guid id)
    {
        var product = _productsService.GetById(id);
        return product is not null ? Ok(product) : NotFound();
    }

    [HttpPost("phones")]
    public IActionResult CreatePhone([FromBody] Phone phone)
    {
        var product = _productsService.Add(phone);
        return product is not null ? Ok(product) : BadRequest();
    }

    [HttpPut("phones")]
    public IActionResult UpdatePhone([FromBody] Phone phone)
    {
        var result = _productsService.Update(phone);
        return result is not null ? Ok(result) : BadRequest();
    }

    [HttpPost("laptops")]
    public IActionResult CreatePhone([FromBody] Laptop laptop)
    {
        var product = _productsService.Add(laptop);
        return product is not null ? Ok(product) : BadRequest();
    }

    [HttpPut("laptops")]
    public IActionResult UpdatePhone([FromBody] Laptop laptop)
    {
        var result = _productsService.Update(laptop);
        return result is not null ? Ok(result) : BadRequest();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteProduct(Guid id)
    {
        var result = _productsService.Delete(id);
        return result ? Ok(result) : BadRequest();
    }
}