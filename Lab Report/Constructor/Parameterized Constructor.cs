using System;
namespace ParaConstructor
{
    class ParaConstructor
    {
        public int a, b;
        public ParaConstructor(int x, int y)
        {
            a = x;
            b = y;
        }
    }
    class MainClass
    {
        static void Main()
        {
            ParaConstructor obj = new ParaConstructor(100, 200);
            Console.WriteLine("Value of a = " + obj.a);
            Console.WriteLine("Value of b = " + obj.b);
            Console.WriteLine("Lab No.: 1(b) Parameterized Constructor\t Name: Sandip Pokharel\t Roll No.: 20900");
        }
    }
}
