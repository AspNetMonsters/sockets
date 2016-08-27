using System;
using System.Net.Http;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting connections");
            for(int i = 0; i<10; i++)
            {
                using(var client = new HttpClient())
                {
                    var result = client.GetAsync("http://aspnetmonsters.com").Result;
                    Console.WriteLine(result.StatusCode);
                }
            }
            Console.WriteLine("Connections done");
        }
    }
}
