using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarjunaConsoleApp
{
    class throwDemo
    {
        static void DisplayAge(int age)
        {
            if(age > 0)
            {
                Console.WriteLine("age is: " + age);
            }
            else
            {
                throw new ArithmeticException("Age cannot be Negative !!!");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                DisplayAge(19);
                DisplayAge(-5);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Exception Caught: " + e.Message);
            }
        }
    }
}
