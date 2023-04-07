using System;
using PatternMatchingClassLibrary;

namespace PatternMatchingExample
{
    class Progam
    {
        static void Main()
        {
            ParentClass pc;

            // object of child class
            pc = new ChildClass() { x = 10, y = 20 };

            if(pc is ChildClass cc)
            {
                Console.WriteLine(cc.x);
                Console.WriteLine(cc.y);
            }
        }
    }
}
