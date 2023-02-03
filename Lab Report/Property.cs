using System;
namespace Property
{
    class Point1
    {
        private int x;
        private int y;
        public int X
        { 
            get { return x; } 
            set { x = value; }
        } 
        public int Y
            { 
            get { return y; } 
            set { y = value; } 
        } 
    }
    class Point2
    {
        static void Main(string[] args)
        {
            Point1 p = new Point1();
            p.X = 10;
            p.Y = 20;
            Console.WriteLine("X : " + p.X);
            Console.WriteLine("Y : " + p.Y);
            Console.WriteLine("Lab No.: 2.Property\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
