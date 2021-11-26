namespace Core.Entities;

public class ProductBrand : BaseEntity
{
    public ProductBrand(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name is required", nameof(name));
        }
        
        Name = name;
    }
    
    public string Name { get; set; }
}