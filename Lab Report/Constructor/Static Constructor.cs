using System;
namespace StaticConstructor
{
    class Employee
    {
        static Employee()
        {
            Console.WriteLine("This is static Constructor");
        }
    }
    class Object
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Lab No.: 1(d) Static Constructor\t Name:Sandip Pokharel\t Roll No.: 20900");
        }
    }
}