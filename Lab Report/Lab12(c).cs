using System;
using System.Collections.Generic;
namespace Lab_Report
{
    class DataStore<T>
    {
        private T[] data = new T[10];
        public  void AddOrUpdate(int index, T item)
        {
            if(index >= 0 && index < 10)
                data[index] = item;
        }
        public T GetData(int index)
        {
            if(index >= 0 && index < 10)
                return data[index];
            else
                return default(T);
        }
    }
    class GenericMethod
    {
        static void Main(string[] args)
        {
            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Kathmandu");
            cities.AddOrUpdate(1, "Biratnagar");
            Console.WriteLine(cities.GetData(1));
            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            Console.WriteLine(empIds.GetData(0));
            Console.WriteLine("Lab12(c)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
