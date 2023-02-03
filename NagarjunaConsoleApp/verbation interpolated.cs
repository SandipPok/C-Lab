using System;

namespace NagarjunaConsoleApp
{
    internal class Verbation
    {
        static void Main(string[] args)
        {
            string variable= "Hello\tWorld";
            string verbation = @"Hello\tWorld";
            Console.WriteLine(variable);
            Console.WriteLine(verbation);
        }
    }
}