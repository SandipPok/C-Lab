using System;
namespace Lab_Report
{
    class Employee
    {
        int id;

        public Employee(int id)
        {
            this.id = id;
        }
        public int this[int x]
        {
            get
            {
                if (x == 0)
                {
                    return this.id;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (x == 0)
                {
                    this.id = (int)value;
                }
            }
        }
    }
    class Indexer
    {
        static void Main(string[] agrs)
        {
            Employee emp1 = new Employee(101);
            Console.WriteLine("===Details of emp1======");
            Console.WriteLine("ID = " + emp1[0]);
            emp1[0] = 202;
            Console.WriteLine("Value after new update");
            Console.WriteLine("=====Details of emp1======");
            Console.WriteLine("ID = " + emp1[0]);
            Console.WriteLine("Lab5(a)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
