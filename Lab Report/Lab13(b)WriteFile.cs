using System;
using System.IO;
using System.Text;
namespace Lab_Report
{
    class WriteFile
    {
        static void Main(string[] args)
        {
            string myfilepath = @"C:\Users\User\Desktop\myFile1.txt";
            FileStream f = new FileStream(myfilepath, FileMode.OpenOrCreate);
            Console.WriteLine("File is created and contents are being written");
            f.WriteByte(65);
            f.WriteByte(10);
            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
                f.WriteByte(32);
            }
            string msg = "How are you ?";
            byte[] byteArrayOfMsg = new UTF8Encoding(true).GetBytes(msg);
            f.Write(byteArrayOfMsg);
            Console.WriteLine("File writing completed");
            Console.WriteLine("Lab13(b)\tName:Sandip Pokharel\tRoll No.:20900");
            f.Close();
        }
    }
}
