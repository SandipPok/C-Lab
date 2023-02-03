using System;
namespace Lab_Report
{
    public enum Week
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public class EnumExample
    {
        public static void Main(string[] args)
        {
            Week we = Week.Wednesday;
            Console.WriteLine("Integral value of {0} is {1}", we, (int)we);
            Console.WriteLine("Lab9(b)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
