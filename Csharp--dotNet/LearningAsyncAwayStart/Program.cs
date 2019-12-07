using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsyncAwayStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine();
        }
        static async void Download()
        {
            //await Network.Download();
            HttpClient client = new HttpClient();

            var data = await client.GetStringAsync("http://www.computrition.com/software-products/hospitality-suite/suitepoint-point-of-sale/");
            Console.WriteLine("Download complete." + data);
        }
    }
    class Network
    {
        static public Task Download()
        {
            return Task.Run(()=>Thread.Sleep(3000));
        }
    }
}
