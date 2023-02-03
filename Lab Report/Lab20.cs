using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Report
{
    class DependencyInjection
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var runner = new Runner(logger);
            runner.Run();
            Console.WriteLine("Lab20\tName:Sandip Pokharel");
        }
    }
    class Runner
    {
        private ILogger _logger;
        public Runner(ILogger logger)
        {
            _logger = logger;
        }
        public void Run()
        {
            // Do some work
            _logger.Log("Message to be logged");
        }
    }
    interface ILogger
    {
        void Log(string message);
    }
    class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
