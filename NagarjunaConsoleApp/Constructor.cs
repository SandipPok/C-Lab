using System;
namespace Example
{
    class Basic
    {
        static int count = 0;
        public Basic()
        {
            Console.WriteLine("Hello from Instance Constructor");
            count++;
        }
        static Basic()
        {
            Console.WriteLine("Hello from Static Constructor");
            count = 400;
        }
        static void Main(string[] args)
        {
            Basic d1 = new Basic();
            Console.WriteLine("Hello from main");
            Console.WriteLine("value of count= " + count);
            Basic d2 = new Basic();
            Console.WriteLine("value of count= " + count);
        }
    }
}
