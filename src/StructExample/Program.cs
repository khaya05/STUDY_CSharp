using System;

class Program
{
    static void Main()
    {
        //create structure instance
        Category category = new Category(20,"general");

        //initialize fields through properties
        //category.CategoryId = 20;
        //category.CategoryName = "General";

        //access methods
        Console.WriteLine(category.CategoryId);
        Console.WriteLine(category.CategoryName);
        Console.WriteLine(category.GetCategoryNameLength());

        Console.ReadKey();
    }
}