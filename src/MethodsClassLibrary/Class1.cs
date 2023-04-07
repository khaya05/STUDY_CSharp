public class Product
{
    //fields
    private int productID;
    private string productName;
    private double cost;
    private double tax;
    private int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    //constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    // setter for productId
    public void SetProductID(int productID)
    {
        this.productID = productID;
    }

    //getter for productid
    public int GetProductID()
    {
        return productID;
    }

    //setter: productName
    public void SetProductName(string value)
    {
        productName = value;
    }

    // getter: productName
    public string GetProductName()
    {
        return productName;
    }    
    
    //setter: cost
    public void SetCost(double value)
    {
        cost = value;
    }

    // getter: cost
    public double GetCost()
    {
        return cost;
    }    

    //setter: tax
    public void SetTax(double value)
    {
        tax = value;
    }

    // getter: tax
    public double GetTax()
    {
        return tax;
    }

    //setter: quantityInStock
    public void SetQuantityInStock(int value)
    {
        quantityInStock = value;
    }

    // getter: tax
    public int GetQuantityInStock()
    {
        return quantityInStock;
    }

    // getter: date of 
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }

    // method
    public void CalculateTax(double percentage = 4.5)
    {
        double t;

        if(this.cost <= 20_000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * percentage / 100;
        }

        tax = t;
    }

    //statis Setter: totalNoOfproducts

    public static void SetTotalNoOfProducts(int value)
    {
        TotalNoProducts = value;
    }

    //statis getter: totalNoOfproducts

    public static int GetTotalNoOfProducts()
    {
        return TotalNoProducts;
    }

    // static: Calculate total quantity
    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        return product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
    }
}

