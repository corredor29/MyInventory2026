using System;

namespace MyInventory2026.src.modules.products.Infrastructure.entity;

public class ProductEntity
{
    public string Id {get; set;} = string.Empty;

    public string codeInv {get; set;} = string.Empty;
    public string nameProduct {get; set;} = string.Empty;
    public string stock {get; set;} = string.Empty;
    public string Stock_Min {get; set;} = string.Empty;
    public string Stock_Max {get; set;} = string.Empty;
}
