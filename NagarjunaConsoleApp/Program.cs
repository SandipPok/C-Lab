using System;
namespace NagarjunaConsoleApp
{
    class Circle
    {
        private double _Radius = 3.5; // Private field
        // Property
        public double Radius
        {
            // get accessor 
            get
            {
                return _Radius;
            }
            // set accessor
            set
            { 
                _Radius = value;
            }
        }
    }

    internal class CircleTest
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("Radius value = " + c1.Radius);
            c1.Radius = 10.5;
            Console.WriteLine("Radius value = " + c1.Radius);
        }
    }
}