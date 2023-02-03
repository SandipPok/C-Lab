using System;
namespace CopyConstructor
{
    class Employee
    {
        private string name;
        private int age;
        public Employee(Employee emp)   // declaring Copy Constructor
        {
            name = emp.name;
            age = emp.age;
        }
        public Employee(string name, int age)   // Instance Constructor
        {
            this.name = name;
            this.age = age;
        }
        public string Details
        {
            get { return "The age of " + name + " is " + age.ToString(); }
        }
    }
    class Empdetail
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Asus", 19);
            Employee emp2 = new Employee(emp1);
            Console.WriteLine(emp2.Details);
            Console.WriteLine("Lab No.: 1(c) Copy Constructor\t Name:Sandip Pokharel\t Roll No.: 20900");
        }
    }
}
