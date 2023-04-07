using System;

public class Product
{
    //fields
    public int productID;
    public string productName;  
    public int productCost;
    public int quantityInStock;
    public static int totalNoProducts;
    public const string CategoryName = "Eleteonocs";
    public readonly string dateOfPurchase;

    public Product() {
        dateOfPurchase = DateTime.Now.ToShortDateString();
    }

    public void Method()
    {
        totalNoProducts++;
    }
}