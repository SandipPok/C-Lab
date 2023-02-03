using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarjunaConsoleApp
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
        public ChildClass():base()
        {
            Console.WriteLine("Child Constructor");
            base.Print();
            Console.WriteLine(base.x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
            c.Print();
        }
    }
}
