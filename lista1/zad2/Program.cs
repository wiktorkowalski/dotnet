using System;
using System.Collections.Specialized;
using System.Dynamic;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podane argumenty:");

            foreach (var item in args)
            {
                Console.WriteLine(item);
            }

            var username = Environment.GetEnvironmentVariable("username");

            Console.WriteLine($"Witaj {username}");
            Console.ReadKey();
        }
    }
}
