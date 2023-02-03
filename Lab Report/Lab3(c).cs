using System;
namespace Lab_Report
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Enter the row of matrices : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column of matrices: ");
            b = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[a, b];

            Console.WriteLine("Enter the elements of the first matrices: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            /* Console.WriteLine("\nThe matrix is : \n");
            for(int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                { 
                    Console.Write("{0}\t", arr1[i, j]);
                }
                Console.WriteLine("");
            } */

            Console.WriteLine("Enter the row of matrices : ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column of matrices: ");
            d = Convert.ToInt32(Console.ReadLine());
            int[,] arr2 = new int[c, d];

            Console.WriteLine("Enter the elements of the second matrices: ");
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            /* Console.WriteLine("\nThe matrix is : \n");
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
                Console.WriteLine("");
            } */
            if (b != c)
            { Console.WriteLine("Matrix multiplication isn't possible"); }
            else
            {
                int[,] mul = new int[a, d];
                for(int i = 0; i < a; i++)
                {
                    for(int j = 0; j < d; j++)
                    {
                        mul[i, j] = 0;
                        for (int k = 0; k< b; k++)
                        {
                            mul[i, j] += arr1[i, k] * arr2[k, j];
                        }
                    }
                }
                Console.WriteLine("The product of the two matrices is :");
                for(int i = 0; i < a; i++)
                {
                    for(int j= 0; j < b; j++)
                    {
                        Console.Write(mul[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Lab3(c)\tName:Sandip Pokharel\tRoll No.:20900");
        } 
    }
}
