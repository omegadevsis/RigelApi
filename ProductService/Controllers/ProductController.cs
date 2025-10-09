using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductService.Models;
using ProductService.Repositories;
using ProductService.Services;

namespace ProductService.Controllers;

[Route("v1/products")]
public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductRepository _productRepository;

    public ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
    {
        _logger = logger;
        _productRepository = productRepository;
    }
    
    // GET
    [HttpGet]
    //[Route("products")]
    public async Task<ActionResult> Get()
    {
        try
        {
            return Ok(_productRepository.Get());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, GetType().FullName);
            return BadRequest(new { Mensagem = "Erro ao requisitar dados" });
        }
    }
    
    [HttpPost]
    public async Task<ActionResult> Post(int id, string name)
    {
        try
        {
            return Ok(_productRepository.Create(id, name));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, GetType().FullName);
            return BadRequest(new { Mensagem = "Erro ao requisitar dados" });
        }
    }
}