namespace MyInventory2026.src.modules.Products.Domain.ValueObject;

public record class ProductsStock_Min
{
    public string Value {get;}

    private ProductsStock_Min(string value)
    {
        Value=value;
    }
    public static ProductsStock_Min Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Products Stock_Min cannot be empty", nameof(value));
        }
        if (value.Trim().Length < 0)
        {
            throw new ArgumentException("Products Stock_Min cannot the null value",nameof(value));
        }
        return new ProductsStock_Min (value.Trim());
    }
    public override string ToString() => Value;
}
