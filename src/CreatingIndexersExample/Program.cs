using System;

class Program
{
    static void Main()
    {
        // create an object of Car clsaa
        Car c = new Car();

        // call get accesor
        Console.WriteLine(c[0]);

        // call set accessor of index
        c[0] = "Nissan";

        Console.WriteLine(c[0]);
    }
}