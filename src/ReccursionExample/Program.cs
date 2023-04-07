using System;

class Sample
{
    public double Factorial(int number)
    {
        if(number == 1)
        {
            return 1;
        }

        return number * Factorial(number - 1);
    }
}

class Progam
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());

        // create object
        Sample sample = new Sample();
        double fact = sample.Factorial(number);

        Console.WriteLine("Factorial of " + number + " is " + fact);
    }
}