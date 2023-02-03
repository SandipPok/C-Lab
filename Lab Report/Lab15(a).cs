using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Lab_Report
{
    public delegate int SquareDelegate(int num);
    public delegate void HelloDelegate(string name);
    class LambdaDemo
    {
        static void Main(string[] args)
        {
            LambdaDemo ld = new LambdaDemo();
            HelloDelegate hd = (name) =>
            {
                string msg = "Hello " + name + "Good Morning !";
                Console.WriteLine(msg);
            };
            SquareDelegate sd = (num) => num * num;
            hd("World ");
            int sqr = sd(7);
            Console.WriteLine("Square of 3 is " + sqr);
            Console.WriteLine("Lab 15(a)\tName:Sandip Pokharel\tRoll:20900");
        }
    }
}