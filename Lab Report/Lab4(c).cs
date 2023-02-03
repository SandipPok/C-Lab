using System;
namespace Lab_Report
{
    class StrCheck
    {
        static bool isSubstringPresent(string str, string sub)
        {
            int n = str.Length;
            int cl = sub.Length;

            if (n < cl)
                return false;
            else
                return (str.Substring(0, cl).Equals(sub) && str.Substring(n - cl, cl).Equals(sub));
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string str = Console.ReadLine();
            Console.Write("Enter the substring : ");
            string sub = Console.ReadLine();
            if (isSubstringPresent(str, sub))
                Console.WriteLine("The string start & end with same string");
            else
                Console.WriteLine("The string doesn't start & end with same string");
            Console.WriteLine("Lab4(c)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
