using System;
namespace PrivateConstructor
{
    class Counter
    {
        private Counter() { }  // Private Constructor 
        public static int currentview;
        public static int visitedCount()
        { return ++ currentview; }
    }
    class viewCounterDetails
    {
        static void Main(string[] args)
        {
            Counter.currentview = 1;
            Counter.visitedCount();
            Console.WriteLine("Now the view count is: {0}", Counter.currentview);
            Console.WriteLine("Lab No.: 1(e) Private Constructor\t Name:Sandip Pokharel\t Roll No.: 20900");
        }
    }
}
