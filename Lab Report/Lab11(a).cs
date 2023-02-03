using System;
using System.Collections;
namespace Lab_Report
{
    public class NonGenerics
    {
        public static void Main(string[] args)
        {
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Random");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            var arlist2 = new ArrayList()
            {
                2, "Nepali", true, 4.5, null
            };

            Console.WriteLine("ArrayList 1 Elements");

            for(int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);

            Console.WriteLine("ArrayList 2 Elements");

            for(int i = 0; i < arlist2.Count; i++)
                Console.WriteLine(arlist2[i]);

            Console.WriteLine("Lab11(a)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
