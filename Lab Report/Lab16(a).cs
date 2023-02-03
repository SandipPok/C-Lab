using System;
namespace Lab_Report
{
    public class TryCatch
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 100;
                int b = 0;
                int x = a / b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Rest of the program");
            }
            Console.WriteLine("Lab16(a)\tName:Sandip Pokharel");
        }
    }
}
