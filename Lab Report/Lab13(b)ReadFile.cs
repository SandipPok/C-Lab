using System;
using System.IO;
using System.Text;
namespace Lab_Report
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            string myfilepath = @"C:\Users\User\Desktop\myFile1.txt";
            FileStream f = new FileStream(myfilepath, FileMode.Open, FileAccess.Read);
            Console.WriteLine("File Opened & contents are being read");
            Console.WriteLine("---Contents of the file---\n");
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();
            Console.WriteLine("Lab13(b)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
