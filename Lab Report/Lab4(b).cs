using System;
namespace Lab_Report
{
    public class StringOps
    {
        public void WordsAndChars(string str)
        {
            int index = 0, wordCount = 1;
            if (str.Length == 0)
            {
                wordCount = 0;
            }
            while (index <= str.Length - 1)
            {
                if (str[index] == ' ' || str[index] == '\n' || str[index] == '\t')
                {
                    wordCount++;
                }
                index++;
            }
            Console.Write("Number of words in the string = {0}\n", wordCount);

            string str_trimmed = str.Replace(" ", "");
            Console.WriteLine($"The number of characters in the provided string is " + str_trimmed.Length);
        }

        public void WordOccurrences(string sentence, string word)
        {
            int count = 0;
            int i = 0;
            while ((i = sentence.IndexOf(word, i)) != -1)
            {
                i += word.Length;
                count++;
            }
            Console.WriteLine("No. of Occurrence of '" + word + "' word in a given sentence: {0}", count);
        }
        static void Main(string[] args)
        {
            StringOps strings = new StringOps();
            Console.Write($"Enter the string : ");
            string input = Console.ReadLine().ToString();
            strings.WordsAndChars(input);
            Console.WriteLine($"=====================================");

            string word;
            Console.Write("Enter the Word to Find the Frequency in a given Sentence: ");
            word = Console.ReadLine();
            Console.Write("\n");
            strings.WordOccurrences(input, word);
            Console.WriteLine("Lab4(b)\tName:Sandip Pokharel\tRoll No.:20900");
            Console.ReadKey();
        }
    }
}