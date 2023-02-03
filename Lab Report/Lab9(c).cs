using System;
namespace Lab_Report
{
    public partial class Coords
    {
        private int x;
        private int y;
        public Coords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public partial class Coords
    {
        public void PrintCoords()
        {
            Console.WriteLine("Coords: {0} {1}",x ,y);
        }
    }
    class TestCords
    {
        static void Main(string[] args)
        {
            Coords myCoords = new Coords(1, 2);
            myCoords.PrintCoords();
            Console.WriteLine("Lab9(c)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
