using System;
namespace Lab_Report
{
    public class ParentClass
    {
        public int x = 10 + 12;
        public ParentClass()
        {
            Console.WriteLine("Parent Constructor");
        }
        public void Print()
        {
            Console.WriteLine("I'm a Parent Class");
        }
    }
    public class ChildClass : ParentClass
    {
        public ChildClass() : base()
        {
            Console.WriteLine("Child Constructor");
            base.Print();
            Console.WriteLine(base.x);
        }
    }
    class BaseKey
    {
        static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
            c.Print();
            Console.WriteLine("Lab6\tName:Mahesh Basnet");
        }
    }
}
