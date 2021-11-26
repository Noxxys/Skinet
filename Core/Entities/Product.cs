using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities;

public class Product : BaseEntity
{
    public Product(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Product name cannot be empty");
        }
        
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException("Product description cannot be empty");
        }
        
        Name = name;
        Description = description;
    }
    
    [MaxLength(100)]
    public string Name { get; set; }
    
    [MaxLength(180)]
    public string Description { get; set; }
    
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    
    public string PictureUrl { get; set; } = null!;
    
    public ProductType ProductType { get; set; } = null!;    
    public int ProductTypeId { get; set; }
    
    public ProductBrand ProductBrand { get; set; } = null!;
    public int ProductBrandId { get; set; }
}