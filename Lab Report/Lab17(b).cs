using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Report
{
    class CustomAttribute
    {
        static void Main(string[] args)
        {
            var types = from t in Assembly.GetExecutingAssembly().GetTypes() 
                        where t.GetCustomAttributes<SampleAttribute>().Count() > 0 
                        select t;
            foreach (var t in types)
            {
                Console.WriteLine(t.Name);
            }
            Console.WriteLine("Lab17(b)\tName:Sandip Pokharel");
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class SampleAttribute : Attribute
    {
        public string Name { get; set; }
        public int Version { get; set; }
    }
    [Sample(Name = "John", Version = 1)]
    public class Test
    {
        public int IntValue { get; set; }
        public void Method() { }
    }
}
