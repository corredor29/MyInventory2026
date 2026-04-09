namespace MyInventory2026.src.modules.Products.Domain.ValueObject;

public record class ProductsStock_Max
{
    public string Value {get;}
    private ProductsStock_Max(string value)
    {
        Value= value;
    }
    public static ProductsStock_Max Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Products Stock_Max cannot be empty.",nameof(value));
        }
        if (value.Trim().Length > 1000)
        {
            throw new ArgumentException("Products Stock_Max Maximun Value",nameof(value));
        }
        return new ProductsStock_Max (value.Trim());
    }
    public override string ToString() => Value;
}
