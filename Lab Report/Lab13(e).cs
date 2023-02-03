using System;
using System.IO;
using System.Text;

namespace Lab_Report
{
    class CopyText
    {
        static void Main(string[] args)
        {
            string fpath1 = @"C:\Users\User\Desktop\copy\file1.txt";
            string fpath2 = @"C:\Users\User\Desktop\copy\file2.txt";
            using (TextReader tr = File.OpenText(fpath1))
            {
                Console.WriteLine(tr.ReadToEnd());
            }

            File.Copy(fpath1, fpath2);
            Console.WriteLine("After Text Copied\nFile2");
            Console.WriteLine(File.ReadAllText(fpath2));    
        }
    }
}
