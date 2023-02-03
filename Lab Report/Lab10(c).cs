using System;
namespace Lab_Report
{
    public delegate string MyDel(string str);
    class EventProgram
    {
        event MyDel MyEvent;
        public EventProgram()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        static void Main(string[] args)
        {
            EventProgram obj1 = new EventProgram();
            string result = obj1.MyEvent("Tutorials Point");
            Console.WriteLine(result);
            Console.WriteLine("Lab10(c)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
