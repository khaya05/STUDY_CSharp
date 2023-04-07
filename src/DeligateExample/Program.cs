using System;
using DeligatesClassLibrary;

namespace MainNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object
            Sample s = new Sample();

            // deligate
            MyDeligateType myDeligate;  // ref var for deligate which store a ref for method

            // add method
            myDeligate = new MyDeligateType(s.Add);

            // invoke
            int sum =  myDeligate.Invoke(77, 33);
            Console.WriteLine(sum);

        }
    }
}