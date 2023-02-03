using System;
namespace NagarjunaConsoleApp
{
    public delegate void AddDelegate(int x, int y);
    public delegate string GreetingDelegate(string str);
    class DelegateDemo
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("Sum = " + (a + b));
        }
        public static string Greeting(string name)
        {
            return "Hello " + name + ", Namaste";
        }

        static void Main(string[] args)
        {
            DelegateDemo dd = new DelegateDemo();
            AddDelegate ad = new AddDelegate(dd.AddNumbers);
            GreetingDelegate gd = Greeting;
            ad.Invoke(23, 73);
            string msg = gd("SANDIP");
            Console.WriteLine(msg);
        }
    }
}
