using System.Collections.Generic;
using ProductService.Models;

namespace ProductService.Repositories;

public class ProductRepository:IProductRepository
{
    public List<Product> Get()
    {
        var products = new List<Product>();
        var product1 = new Product(1, "Arroz");
        var product2 = new Product(2, "Feijao");
        var product3 = new Product(3, "Carne");
            
        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        
        return products;
    }

    public Product Create(int id, string name)
    {
        var product1 = new Product(id, name);
        return product1;
    }
}

public interface IProductRepository
{
    List<Product> Get();
    Product Create(int id, string name);
}