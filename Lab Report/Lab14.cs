using System;
using System.Linq;
using System.Text;
namespace Lab_Report
{
    class LINQDemo
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 1, 2, 3, 4, 55 };
            var result1 = from scr in scores where scr > 3 select scr;
            Console.WriteLine("Scores greater than 3 are: ");
            foreach (int i in result1)
            {
                Console.Write(i + " ");
            }
            var result2 = from scr in scores where scr > 3 orderby scr descending select scr;
            Console.WriteLine("\nScores greater than 3 in descending order: ");
            foreach(int i in result2 )
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nLab 14\tName:Sandip Pokharel\tRoll:20900");
        }
    }
}
