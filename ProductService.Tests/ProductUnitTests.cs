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
    
    [Theory]
    [InlineData(4, "Macarrao")]
    [InlineData(5, "Leite")]
    public void Create_DeveRetornarProdutoComIdENomeCorretos(int id, string name)
    {
        // Act
        var produto = _repository.Create(id, name);

        // Assert
        Assert.Equal(id, produto.ProductId);
        Assert.Equal(name, produto.ProductName);
    }
}