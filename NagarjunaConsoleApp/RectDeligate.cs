using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarjunaConsoleApp
{
    public delegate void RectDelegate(double length, double breadth);
    class Rect
    {
        public void GetArea(double length, double breadth)
        {
            string result = $"Area of Rectangle = {length * breadth}";
            Console.WriteLine(result);
        }
        public void GetPerimeter(double length, double breadth)
        {
            string result = $"Perimeter of Rectangle = {2 * (length + breadth)}";
            Console.WriteLine(result);
        }

        static void Main()
        {
            Rect rectangle = new Rect();
            RectDelegate rd1 = rectangle.GetArea;
            RectDelegate rd2 = rectangle.GetPerimeter;
            RectDelegate rd3 = rd1 + rd2;
            rd1.Invoke(34.45, 23.54);
            rd3 -= rd1;
            Console.WriteLine("----------------------");
            rd3(11, 12);
        }
    }
}
