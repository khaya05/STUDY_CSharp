using System;

namespace IDisposableClassLibrary
{
    public class Sample:System.IDisposable
    {
        public Sample() 
        {
            Console.WriteLine("database connected");
        }

        public void DisplayData()
        {
            Console.WriteLine("Reading data from datanbase");
        }

        public void Dispose()
        {
            Console.WriteLine("Database disconnected");
        }
    }
}
