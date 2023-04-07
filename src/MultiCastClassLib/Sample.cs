using System;

namespace MultiCastClassLib
{
    public class Sample
    {
        public void Add(int a, int b)
        {
            int sum = a += b;
            Console.WriteLine("Sum is: " + sum);
        }

        public void Subtract(int a, int b)
        {
            int sum = a -= b;
            Console.WriteLine("Diff is: " + sum);
        }
    }


}
