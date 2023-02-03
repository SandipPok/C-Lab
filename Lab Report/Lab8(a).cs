using System;
namespace Lab_Report
{
    abstract class AbsClass
    {
        public abstract void AbstractMethod();
        public void NonAbstractMethod()
        {
            Console.WriteLine("NonAbstract Method");
        }
    }
    class Derived : AbsClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Overriding Abstract Method in Derived Class");
        }
    }
    class OOPAbstractClass
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.NonAbstractMethod();
            d.AbstractMethod();
            Console.WriteLine("Lab8(a)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
