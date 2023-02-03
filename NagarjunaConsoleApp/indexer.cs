using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarjunaConsoleApp
{
    class Employee
    {
        int id;
        string name;
        string job;
        double salary;

        public Employee(int id,string name, string job, double salary)
        {
            this.id = id;
            this.name = name;
            this.job = job;
            this.salary = salary;  
            
        }
        public object this[int x]
        {
            get
            {
                if(x== 0)
                {
                    return this.id;
                }
                else if(x==1)
                {
                    return this.name;
                }
                else if(x==2)
                {
                    return this.job;
                }
                else if(x ==3)
                {
                    return this.salary;
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
                else if (x == 2)
                {
                    this.job = (string)value;
                }
                else if (x == 3)
                {
                    this.salary = (double)value;
                }
                else
                {
                    Console.WriteLine("Invalid index!");
                }
            }
        }
    }
    internal class indexer
    {
        static void Main(string[] agrs)
        {
            Employee emp1 = new Employee(101, "Ritesh", "Bakchod", 420);
            Console.WriteLine("===Details of emp1======");
            Console.WriteLine("ID = " + emp1[0]);
            Console.WriteLine("Name = " + emp1[1]);
            Console.WriteLine("Job = " + emp1[2]);
            Console.WriteLine("Salary = " + emp1[3]);
            emp1[1] = "Pratham";
            Console.WriteLine("Value after new update");
            Console.WriteLine("=====Details of emp1======");
            Console.WriteLine("ID = " + emp1[0]);
            Console.WriteLine("Name = " + emp1[1]);
            Console.WriteLine("Job = " + emp1[2]);
            Console.WriteLine("Salary = " + emp1[3]);
        }
    }
}
