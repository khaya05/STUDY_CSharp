using EventsClassLibrary;

namespace MainNamespace
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            p.DoWork();
        }

        public void DoWork()
        {
            // obj of publisher class
            Publisher publisher = new Publisher();

            // handle event or subscribe to eventf
            publisher.myEvent += (sender, e) =>
            {
                int c = e.a + e.b;
                Console.WriteLine(c);
            };

            //invoke event
            publisher.RaiseEvent(this, 10, 20);
        }
    }
}