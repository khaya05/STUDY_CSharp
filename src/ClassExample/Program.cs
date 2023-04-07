class Sample
{
    static void Main()
    {
        const string developer = "harsha";
        Product product1,product2,product3;

        //create objects
        product1 = new Product();
        Product.totalNoProducts++;
        product2 = new Product();
        Product.totalNoProducts++;
        product3 = new Product();
        Product.totalNoProducts++;

        //initialize fields
        product1.productID = 1;
        product1.productName = "Mobile";
        product1.productCost = 1200;
        product1.quantityInStock = 99;

        Console.WriteLine("total_no_products:" + Product.totalNoProducts);
        Console.WriteLine("Category:" + Product.CategoryName);

    }
}