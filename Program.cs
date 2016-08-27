﻿using System;
using System.Net.Http;

namespace ConsoleApplication
{
    public class Program
    {
        private static HttpClient Client = new HttpClient();
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting connections");
            for(int i = 0; i<10; i++)
            {
                var result = Client.GetAsync("http://aspnetmonsters.com").Result;
                Console.WriteLine(result.StatusCode);
            }
            Console.WriteLine("Connections done");
            Console.ReadLine();
        }
    }
}
