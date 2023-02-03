using System;
namespace DefaultConstructor
{
    class Addition
    {
        int a, b;
        public Addition()
        {
            a = 100;
            b = 200;
        }
        static void Main(string[] args)
        {
            Addition obj = new Addition();
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.WriteLine("Lab No.: 1(a) Default Constructor \t Name: Sandip Pokharel \t Roll No.: 20900");
        }
    }
}