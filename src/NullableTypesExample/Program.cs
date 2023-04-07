namespace namespace1
{
    class Person
    {
        public int? NoOfChildren;
    }

    class Program
    {
        static void Main()
        {
            Person p1 = new Person() { NoOfChildren = 2};
            Person p2 = new Person() { NoOfChildren = 3 };

           // Console.WriteLine(p1.NoOfChildren);

            Console.WriteLine(p2.NoOfChildren ?? 0); 
        }
    }
}