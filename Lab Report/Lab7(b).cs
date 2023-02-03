using System;
namespace Lab_Report
{
    class Dynamic
    {
        static void Main(string[] args)
        {
            Chocolate ch = new Chocolate();
            ch.flavor();
            Console.WriteLine("Lab7(b)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
    class IceCream
    {
        public IceCream()
        {
            Console.WriteLine("Class : IceCream");
        }
        public virtual void flavor()
        {
            Console.WriteLine("IceCream Type : Vanilla");
        }
    }
    class Chocolate : IceCream
    {
        public Chocolate()
        {
            Console.WriteLine("Class : Chocolate");
        }
        public override void flavor()
        {
            Console.WriteLine("IceCream Type : Chocolate");
        }
    }
}
