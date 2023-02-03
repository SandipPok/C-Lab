using System;
namespace Lab_Report
{
    class Employees
    {
        int id;
        string name;

        public Employees(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public object this[int x]
        {
            get
            {
                if (x == 0)
                {
                    return this.id;
                }
                else if (x == 1)
                {
                    return this.name;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (x == 0)
                {
                    this.id = (int)value;
                }
                else if (x == 1)
                {
                    this.name = (string)value;
                }
                else
                {
                    Console.WriteLine("Invalid index!");
                }
            }
        }
    }
    internal class IndexerOther
    {
        static void Main(string[] agrs)
        {
            Employees emp1 = new Employees(101, "Hello");
            Console.WriteLine("===Details of emp======");
            Console.WriteLine("ID = " + emp1[0]);
            Console.WriteLine("Name = " + emp1[1]);
            emp1[1] = "World";
            Console.WriteLine("Value after new update");
            Console.WriteLine("=====Details of emp======");
            Console.WriteLine("ID = " + emp1[0]);
            Console.WriteLine("Name = " + emp1[1]);
            Console.WriteLine("Lab5(b)\tName:Sandip Pokharel\tRoll No.: 20900");
        }
    }
}
