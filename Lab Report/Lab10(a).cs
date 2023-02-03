using System;
namespace Lab_Report
{
    public delegate void SimpleDelegate();
    class DelegateTest
    {
        static void Main(string[] args)
        {
            SimpleDelegate d = new SimpleDelegate(MyFunc);
            d();
        }
        public static void MyFunc()
        {
            Console.WriteLine("I was called by delegate");
            Console.WriteLine("Lab10(a)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
