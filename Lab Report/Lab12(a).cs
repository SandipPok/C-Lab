using System;
using System.Collections;
namespace Lab_Report
{
    public class TestClass<T>
    {
        T[] obj = new T[2];
        int count = 0;
        public void Add(T item)
        {
            if(count + 1 < 3)
            {
                obj[count] = item;
            }
            count++;
        }
        public T this[int index]
        { 
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
    class GenericClass
    {
        static void Main(string[] args)
        {
            TestClass<int> intObj = new TestClass<int>();
            intObj.Add(1);
            intObj.Add(2);
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(intObj[i]);
            }
            Console.WriteLine("Lab12(a)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
