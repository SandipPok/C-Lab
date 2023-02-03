using System;
namespace Lab_Report
{
    class SubStrUpper
    {
        /*public static string findSubSting(string str)
        {
            string word = "";
            for (int i = 0; i < str.Length - 1; i++)
            {
                if(str[i] == ',')
                {
                    int comma = str.IndexOf(',');
                    word = str.Substring(0, comma);
                    word = word.ToUpper();
                    return word;
                    break;
                }
                else
                {
                    word = "The string doesn't have comma.";
                    return word;
                    break;
                }
            }
            return word;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();
            findSubSting(str);
            if(findSubSting(str) != null)
            {
                Console.WriteLine("The string before ,(In Upper Case) is : " + findSubSting(str));
            }
        }*/
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string str = Console.ReadLine();
            string strBefore = str.Substring(0, str.IndexOf(','));

            Console.Write(strBefore.ToUpper());
            Console.WriteLine("\nLab4(d)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
