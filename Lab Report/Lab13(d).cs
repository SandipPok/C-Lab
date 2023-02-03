using System;
using System.IO;
using System.Text;
namespace Lab_Report
{
    class StreamReaderWriter
    {
        static void Main(string[] args)
        {
            string fpath = @"C:\Users\User\Desktop\myFile1.txt";
            FileStream f1 = new FileStream(fpath, FileMode.OpenOrCreate);
            StreamWriter s1 = new StreamWriter(f1);
            s1.WriteLine("File Handling Example");
            s1.Close();
            f1.Close();
            FileStream f2 = new FileStream(fpath, FileMode.Open);
            StreamReader s2 = new StreamReader(f2);
            string data = s2.ReadLine();
            Console.WriteLine("The data in the file is as follows: ");
            Console.WriteLine(data);
            s2.Close();
            f2.Close();
            Console.WriteLine("Lab13(d)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
