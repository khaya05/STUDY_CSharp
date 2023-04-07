using System;
using MultiCastClassLib;

namespace MultiCastDeligates
{
    class Program
    {
        static void Main(string[] args)
        {
            //object
            Sample s = new Sample();
            
            // del ref var
            MyDeligateType myDeligate;

            // add ref for first target meth
            myDeligate = s.Add;

            // add ref for 2nd target meth
            myDeligate += s.Subtract;

            // invoke
            myDeligate.Invoke(10, 40);
        }
    }
}