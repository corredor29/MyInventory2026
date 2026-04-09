namespace MyInventory2026.src.modules.Products.Domain.ValueObject;

public record class ProductsName
{
    public string Value {get;}

    private ProductsName(string value)
    {
        Value= value;
    }
    public static ProductsName Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Products name cannot be empy",nameof(value));
        }
        if (value.Trim().Length< 3)
        {
            throw new ArgumentException("Product name cannot be empy",nameof(value));
        }
        return new ProductsName (value.Trim());
    }
    public override string ToString() => Value;
}
