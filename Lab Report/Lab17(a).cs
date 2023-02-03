using System;
namespace Lab_Report
{
    public class BuiltInAttributes
    {
        [Obsolete("Don't use OldMethod, use NewMethod instead", false)]
        static void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }

        public static void Main()
        {
            OldMethod();
            Console.WriteLine("Lab17(a)\tName:Sandip Pokharel");
        }
    }
}
