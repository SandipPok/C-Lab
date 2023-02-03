using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab_Report
{
    class LinqLambda
    {
        static void Main(string[] args)
        {

            int[] fibNum = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            double averageValue = fibNum.Where(num => num % 2 == 1).Average();
            Console.WriteLine(averageValue);
            Console.WriteLine("Lab15(b)\tName:Sandip Pokharel");
        }
    }
}
