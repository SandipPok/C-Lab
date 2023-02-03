using System;
namespace Lab_Report
{
    public delegate void RectangleDelegate(double Width, double Height);
    public class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area is {0}", (Width * Height));
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter is {0}", (2 * (Width * Height)));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectangleDelegate rectDelegate = new RectangleDelegate(rect.GetArea);
            rectDelegate += rect.GetPerimeter;
            rectDelegate(23.45, 67.89);
            Console.WriteLine();
            rectDelegate.Invoke(13.54, 76.89);
            Console.WriteLine();
            rectDelegate -= rect.GetPerimeter;
            rectDelegate.Invoke(13.45, 76.89);
            Console.WriteLine("Lab10(b)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
