using System;
namespace Lab_Report
{
    class Reverse
    {
        public static void Main(string[] args)
        {
            string str;
            int l = 0;
            
            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            l = str.Length - 1;
            int ch = l;
            Console.Write("The string in reverse order is : ");
            while (l >= 0)
            {
                Console.Write("{0}", str[l]);
                l--;
            }
            Console.WriteLine("\nThe characters of the string in reverse order are");
            while(ch >= 0)
            {
                Console.Write("{0}\t", str[ch]);
                ch--;
            }
            Console.WriteLine("\nLab4(a)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
