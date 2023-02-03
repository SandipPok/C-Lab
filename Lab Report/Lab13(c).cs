using System;
using System.IO;
using System.Text;
namespace Lab_Report
{
    class TextReaderWriter
    {
        static void Main(string[] args)
        {
            string fpath = @"C:\Users\User\Desktop\myFile1.txt";
            if(File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            using (TextWriter tw = File.CreateText(fpath))
            {
                tw.WriteLine("C# File Handling");
                tw.WriteLine("TextReader Class and TextWriter Class");
            }
            using (TextReader tr = File.OpenText(fpath))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            Console.WriteLine("Lab13(c)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
