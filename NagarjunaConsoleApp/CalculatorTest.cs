using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarjunaConsoleApp
{
    public class Calculator<T>
    {
        public void Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine("Result = " + (x + y));
        }
        public void Sub(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine("Result = " + (x - y));
        }
        public void Mul(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine("Result = " + (x * y));
        }
        public void Div(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine("Result = " + (x / y));
        }
    }
    internal class CalculatorTest
    {
        static void Main(string[] args)
        {
            Calculator <float> c = new Calculator<float>();
            c.Add(3, 5);
            c.Sub(3.6f, 5.6f);
            c.Mul(3.6f, 5.6f);
            c.Div(10.6f, 5.3f);
        }
    }
}
