using System;
using System.IO;
using System.Text;
namespace Lab_Report
{
    class BinaryReaderWriter
    {
        static void Main(string[] args)
        {
            string fName = @"C:\Users\User\Desktop\myFile4.dat";
            int value1 = 5;
            int value2 = 24;
            using (BinaryWriter bw = new BinaryWriter(File.Open(fName, FileMode.Create)))
            {
                bw.Write(value1);
                bw.Write(value2);
            }
            using (BinaryReader br = new BinaryReader(File.Open(fName, FileMode.Open)))
            {
                int a = br.ReadInt32();
                int b = br.ReadInt32();
                Console.WriteLine("First value is {0}\nSecond value is {1}",a , b);
                Console.WriteLine("Lab13(a)\tName:Sandip Pokharel\tRoll No.:20900");
            }
        }
    }
}
