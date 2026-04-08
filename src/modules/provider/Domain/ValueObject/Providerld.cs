namespace MyInventory2026.src.modules.provider.Domain.valueObject;

// Ojeto inmutable 
// record compara el valor 
// sealed evita que nadie pueda heredar la clase 
public sealed record ProviderId
{
    // agregamos un valor para que solo se pueda leer 
    public string Value { get; }

    // valida y encapsula el id que ya viene 
    private ProviderId(string value)
    {
        Value = value;
    }

    public static ProviderId Create(string value)
    {
        // si el valor del id es null o undefined lanza un error y indica que no se cree el proyecto 
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Provider id cannot be empty.", nameof(value));
        }
        // 

        return new ProviderId(value.Trim());
    }

    // el override deja que el valor Tostring  
    public override string ToString() => Value;
}