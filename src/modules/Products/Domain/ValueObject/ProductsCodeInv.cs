namespace MyInventory2026.src.modules.Products.Domain.ValueObject;

public record class ProductsCodeInv
{
    public string Value {get;}

    private ProductsCodeInv(string value)
    {
        Value= value;
    }
    public static ProductsCodeInv Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("ProductsCodeInv cannot be empty.",nameof(value));
        }
        
        return new ProductsCodeInv(value.Trim());    
    }

}
