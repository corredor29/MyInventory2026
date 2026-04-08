namespace MyInventory2026.src.modules.Products.Domain.ValueObject;

public sealed record ProductsId
{
    public string Value {get;}

    private ProductsId(string value)
    {
        Value= value;
    }
    public static ProductsId Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException ("Product Id cannont be empty.", nameof(value));
        }
        return new ProductsId (value.Trim());
    }
    public override string ToString() => Value;
}
