using System;

namespace ClassLibrary1
{
    public class Sample
    {
        //constructor
        public Sample()
        {
            Console.WriteLine("File is open");
        }

        //destructor
        ~Sample()
        {
            Console.WriteLine("File is closed");
        }
    }
}
