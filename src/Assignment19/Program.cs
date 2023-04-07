using System;

class Program
{
    static void Main()
    {
        byte a = 10;
        int b = 10;
        string c = "10.34";

        decimal d;

        short s = a;
        short i = (short)b;
        double j = double.Parse(c);
        bool k = decimal.TryParse(c, out decimal n);
        string z = "11.56";

        Console.WriteLine(s);
        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(n);
        Console.WriteLine(z);

    }
}