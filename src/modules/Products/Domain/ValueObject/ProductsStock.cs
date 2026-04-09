namespace MyInventory2026.src.modules.Products.Domain.ValueObject;

public record class ProductsStock
{
    public string Value {get;}

    private ProductsStock(string value)
    {
        Value= value;
    }
    public static ProductsStock Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Product Stock cannot be empty.", nameof(value));
        }
        if (value.Trim().Length < 0)
        {
            throw new ArgumentException("Product Stock it cannot be the null value", nameof(value));
        }
        return new ProductsStock(value.Trim());
    }
    public override string ToString() => Value;
}
