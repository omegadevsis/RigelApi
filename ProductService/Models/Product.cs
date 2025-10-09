namespace ProductService.Models;

public class Product(int productId, string productName)
{
    public int ProductId { get; set; } = productId;
    public string ProductName { get; set; } = productName;
}