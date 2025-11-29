using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProductService.Models;

public class Product()
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "ProductId must be greater than 0")]
    public int ProductId { get; set; }
    
    [Required(ErrorMessage = "ProductName is required")]
    [Length(10, 20)]
    // [MaxLength(100, ErrorMessage = "Foi digitado mais de 100 caracteres")]
    // [MinLength(10, ErrorMessage = "Foi digitado menos de 10 caracteres")]
    public string ProductName { get; set; } = null!;
}