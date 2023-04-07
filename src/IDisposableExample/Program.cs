using System;
using IDisposableClassLibrary;

class Program
{
    static void DoWork()
    {
        using Sample s = new Sample();
        s.DisplayData();
        
    }
    static void Main()
    {
        DoWork();
    }
}
