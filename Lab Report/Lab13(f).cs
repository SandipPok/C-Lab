using System;
using System.Text;
using System.IO;

namespace Lab_Report
{
    class KeyCapture
    {
        private StringBuilder sb;
        private ConsoleKeyInfo keyInfo;

        public KeyCapture()
        {
            sb = new StringBuilder();
        }

        public void Run()
        {
            while ((keyInfo = Console.ReadKey()).Key != ConsoleKey.Escape)
            {
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    sb.Append("\r\n");
                }
                else if (keyInfo.Key == ConsoleKey.OemPeriod)
                {
                    sb.Append(keyInfo.KeyChar);
                    using (StreamWriter writer = new StreamWriter("keys.txt", true))
                    {
                        writer.Write(sb.ToString());
                    }
                    sb.Clear();
                }
                else
                {
                    sb.Append(keyInfo.KeyChar);
                }
            }

            sb.Append("\r\n");
            using (StreamWriter writer = new StreamWriter("keys.txt", true))
            {
                writer.Write(sb.ToString());
            }
            sb.Clear();
        }

        static void Main(string[] args)
        {
            KeyCapture kc = new KeyCapture();
            Thread t = new Thread(kc.Run);
            t.Start();
        }
    }
}