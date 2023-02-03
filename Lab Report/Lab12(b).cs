using System;
using System.Collections.Generic;
namespace Lab_Report
{
    public class GeClass<T>
    {
        public GeClass(T item, string name)
        {
            Item = item;
            Name = name;
        }
        public T Item { get; }
        public string Name { get; }
    }
    class GenericField
    {
        static void Main(string[] args)
        {
            var a = new GeClass<int>(100, "One Hundred");
            Console.WriteLine($"{a.Item} : {a.Name}");
            var b = new GeClass<string>("Hello", "World");
            Console.WriteLine($"{b.Item} : {b.Name}");
            Console.WriteLine("Lab10(b)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
