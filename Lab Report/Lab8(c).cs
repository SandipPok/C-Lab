using System;
namespace Lab_Report
{
    interface calc1
    {
        int add(int a, int b);
    }
    interface calc2
    {
        int sub(int x, int y);
    }
    interface calc3
    {
        int mul(int r, int s);
    }
    interface calc4
    {
        int div(int c, int d);
    }
    class Calculation : calc1, calc2, calc3, calc4
    {
        public int result1, result2, result3, result4;
        public int add(int a, int b)
        {
            return result1 = a + b;
        }
        public int sub(int x, int y)
        {
            return result2 = x - y;
        }
        public int mul(int r, int s)
        {
            return result3 = r * s;
        }
        public int div(int c, int d)
        {
            return result3 = c / d;
        }
    }
    class MulInherit
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            c.add(8, 2);
            c.sub(20, 10);
            c.mul(5, 2);
            c.div(20, 10);
            Console.WriteLine("Multiple Inheritance concept Using Interface: ");
            Console.WriteLine("Addition : " + c.result1);
            Console.WriteLine("Substraction : " + c.result2);
            Console.WriteLine("Multiplication : " + c.result3);
            Console.WriteLine("Division : " + c.result4);
            Console.WriteLine("Lab8(c)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
