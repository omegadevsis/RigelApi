using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProductService.Models;

public class Product
{
    // [Required]
    // [Range(1, int.MaxValue, ErrorMessage = "ProductId must be greater than 0")]
    public int ProductId { get; set; }
    
    // [Required(ErrorMessage = "ProductName is required")]
    // [Length(10, 20)]
    public string ProductName { get; set; } = string.Empty;

    public Product(int productId, string productName) 
    {
        ProductId = productId;
        ProductName = productName;
    }
    
}