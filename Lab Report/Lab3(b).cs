using System;
namespace Lab_Report
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][,] jaggedArray = new int[3][,]
            {
                new int[,] { { 1, 8 }, { 6, 7 } },
                new int[,] { { 0, 3 }, { 5, 6 }, { 9, 10 } },
                new int[,] { { 11, 23}, { 100, 88}, { 0, 10} }
            };
            Console.WriteLine("[" + jaggedArray[0][0, 0] + ", " + jaggedArray[0][0, 1] + "]");
            Console.WriteLine("[" + jaggedArray[1][2, 0] + ", " + jaggedArray[1][2, 1] + "]");
            Console.WriteLine("[" + jaggedArray[2][1, 0] + ", " + jaggedArray[2][1,1] + "]");
            Console.WriteLine("Lab No.: 3(b)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}