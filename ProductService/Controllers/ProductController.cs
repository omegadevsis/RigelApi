using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductService.Models;
using ProductService.Repositories;
using ProductService.Services;

namespace ProductService.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
    : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> Get()
    {
        try
        {
            return Ok(productRepository.Get());
        }
        catch (Exception ex)
        {
            logger.LogError(ex, GetType().FullName);
            return BadRequest(new { Mensagem = "Erro ao requisitar dados" });
        }
    }
    
    [HttpPost]
    public IActionResult Post([FromBody] Product product)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                productRepository.Create(product);
                return Ok(productRepository.Create(product));
                
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, GetType().FullName);
            return NotFound();
        }
    }
}