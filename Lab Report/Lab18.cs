using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace Lab_Report
{
    class AsyncProgram
    {
        public async Task<int> GetUrlContentLengthAsync(string url)
        {
            Console.WriteLine($"Connecting to {url} and fetching the contents..");
            var client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync(url);
            DoIndependentWork();
            string contents = await getStringTask;
            Console.WriteLine("Fetching completed!");
            return contents.Length;
        }
        void DoIndependentWork()
        {
            Console.WriteLine("Working..");
            Console.WriteLine("Completed");
        }
        static void Main(string[] args)
        {
            AsyncProgram ap = new AsyncProgram();
            Task<int> result = ap.GetUrlContentLengthAsync("https://thepcgames.net/");
            Console.WriteLine("Length of the contents : {0}", result.Result);
            Console.WriteLine("Lab18\tName:Sandip Pokharel");
        }
    }
}
