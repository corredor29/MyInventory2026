using MyInventory2026.src.modules.Products.Domain.ValueObject;

namespace MyInventory2026.src.modules.Products.Domain.Aggregate;

public class Product
{
    public ProductsId Id {get; private set;}
    public ProductsCodeInv CodeInv {get; private set;}
    public ProductsName NameProduct {get; private set;}
    public ProductsStock Stock {get; private set;}
    public ProductsStock_Min Stock_Min {get; private set;}
    public ProductsStock_Max Stock_Max {get; private set;}

    private Product (ProductsId id, ProductsCodeInv codeInv, ProductsName nameProduct, ProductsStock stock, ProductsStock_Min stock_Min, ProductsStock_Max stock_Max)
    {
        Id = id;
        CodeInv = codeInv;
        NameProduct = nameProduct;
        Stock = stock;
        Stock_Min = stock_Min;
        Stock_Max = stock_Max;
    }
    public static Product Create(string id, string codeInv, string nameProduct, string stock, string stock_Min, string stock_Max)
    {
        return new Product(
            ProductsId.Create(id),
            ProductsCodeInv.Create(codeInv),
            ProductsName.Create(nameProduct),
            ProductsStock.Create(stock),
            ProductsStock_Min.Create(stock_Min),
            ProductsStock_Max.Create(stock_Min)
        );
    }
}

