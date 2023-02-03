using System;
namespace Lab_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, temp;
            int[] arr = new int[10];
            Console.WriteLine("Enter element of array; ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("arr[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Elements of array in sorted ascending order: ");
            for(i= 0; i< 10; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine("\nLab No.: 3(a)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
