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
    public async Task ValidarCodeInvUnico(string value)
    {
        bool Existe = await _context.Products
            .AnyAsync(p => p.CodeInv == value);

        if (Existe)
        {
            throw new Exception("El CodeInv ya existe");
        }
    }
}
