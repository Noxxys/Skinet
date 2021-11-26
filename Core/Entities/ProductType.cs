namespace Core.Entities;

public class ProductType : BaseEntity
{
    public ProductType(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Product type name cannot be empty");
        }
        
        Name = name;
    }

    public string Name { get; set; }
}