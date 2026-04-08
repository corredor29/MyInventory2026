using MyInventory2026.src.modules.Products.Domain.ValueObject;

namespace MyInventory2026.src.modules.Products.Domain.Aggregate;

public class Products
{
    public ProductsId Id {get; private set;}
    public ProductsCodeInv CodeInv {get; private set;}
    public ProductsNameProduct NameProduct {get; private set;}
    public ProductsStock Stock {get; private set;}
    public ProductsStock_Min Stock_Min {get; private set;}
    public ProductsStock_Max Stock_Max {get; private set;}

    private Products (ProductsId id, ProductsCodeInv codeInv, ProductsNameProduct nameProduct, ProductsStock stock ProductsStock_Min stock_Min ProductsStock_Max stock_Max)
    {
        Id = id;
        CodeInv = codeInv;
        NameProduct = nameProduct;
        Stock = stock;
        Stock_Min = stock_Min;
        Stock_Max = stock_Max;
    }
    public static Products Create(string id, string codeInv, string nameProduct, string stock, string stock_Min, string stock_Max)
    {
        return new Products(
            ProductsId.Create(id),
            ProductsCodeInv.Create(codeInv),
            ProductsNameProduct.Create(nameProduct),
            ProductsStock.Create(stock),
            ProductsStock_Min.Create(stock_Min),
            ProductsStock_Max.Create(stock_Min)
        );
    }
}

