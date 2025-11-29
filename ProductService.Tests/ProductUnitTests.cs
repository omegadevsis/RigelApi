using System.Collections.Generic;
using Moq;
using ProductService.Models;
using ProductService.Repositories;
using ProductService.Services;

namespace ProductService.Tests;

public class ProductUnitTests
{
    private readonly IProductRepository _repository;

    public ProductUnitTests()
    {
        _repository = new ProductRepository();
    }

    [Fact]
    public void GetAllTest()
    {
        var result = _repository.Get();
        Assert.NotNull(result);
        Assert.Equal(3, result.Count);
        Assert.Contains(result, p => p.ProductName == "Arroz");
    }
    
    // [Theory]
    // // [InlineData(4, "Macarrao")]
    // // [InlineData(5, "Leite")]
    // public void Create_DeveRetornarProdutoComIdENomeCorretos(Product product)
    // {
    //     // Act
    //     var produto = _repository.Create(product);
    //
    //     // Assert
    //     Assert.Equal(product.ProductId, produto.ProductId);
    //     Assert.Equal(product.ProductName, produto.ProductName);
    // }
}