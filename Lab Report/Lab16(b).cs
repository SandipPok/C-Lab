using System;
namespace Lab_Report
{
    public class ThrowExample
    {
        static void DisplayAge(int age)
        {
            if (age > 0)
            {
                Console.WriteLine("age is: " + age);
            }
            else
            {
                throw new ArithmeticException("Age cannot be Negative");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                DisplayAge(90);
                DisplayAge(-5);
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
            }
            Console.WriteLine("Lab16(b)\tName:Sandip Pokharel");
        }
    }
}
