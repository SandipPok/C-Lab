using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Report
{
    class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("Derived - Method1");
        }
        //This is called Method Hiding or Shadowing.
        public new void Method2() // Or new public void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }
    class MethodOver
    {
        static void Main(string[] args)
        {
            BaseClass bc1 = new BaseClass();
            bc1.Method1(); // Base - Method1
            bc1.Method1(); // Base - Method2

            DerivedClass dc = new DerivedClass();
            dc.Method1(); // Derived - Method1
            dc.Method2(); // Derived - Method2

            BaseClass bc2 = new BaseClass();
            bc2.Method1(); // Derived - Method1
            bc2.Method2(); // Base - Method2
            Console.WriteLine("Lab7(a)\tName:Mahesh Basnet");
        }
    }
}
