using System;
using System.IO;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.Replace(args[0], args[1]);
            Console.WriteLine(text);
        }
    }
}
