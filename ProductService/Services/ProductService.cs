using System.Collections.Generic;
using System.Threading.Tasks;
using ProductService.Models;
using ProductService.Repositories;

namespace ProductService.Services;

public class ProductService
{
    private readonly IProductRepository _repo;

    public ProductService(IProductRepository repo)
    {
        _repo = repo;
    }

    public List<Product> GetProductByIdAsync()
    {
        var product = _repo.Get();
        if (product == null)
            throw new KeyNotFoundException("Produto não encontrado");

        return product;
    }
}