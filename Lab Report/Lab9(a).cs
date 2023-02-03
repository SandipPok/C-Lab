using System;
namespace Lab_Report
{
    struct Employ
    {
        public int id;
        public void getId(int id)
        {
            Console.WriteLine("Employee Id: " + id);
        }
    }
    class Structure
    {
        static void Main(string[] args)
        {
            Employ emp = new Employ();
            emp.id = 1;
            emp.getId(emp.id);
            Console.WriteLine("Lab9(a)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
