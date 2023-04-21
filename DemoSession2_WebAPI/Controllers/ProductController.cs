using DemoSession2_WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoSession2_WebAPI.Controllers;
[Route("api/product")]
public class ProductController : Controller
{

    private ProductServices productServices;

    public ProductController(ProductServices _productServices)
    {
        this.productServices = _productServices;
    }
 
    [Produces("application/json")]
    [HttpGet("findall")]
    public IActionResult FindAll()
    {
        try
        {
            return Ok(productServices.FindAll());
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return BadRequest();
        }
    }

    [Produces("application/json")]
    [HttpGet("findall2")]
    public IActionResult FindAll2()
    {
        try
        {
            return Ok(productServices.findAll2());
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return BadRequest();
        }
    }
}
