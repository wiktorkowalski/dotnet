using System;
using System.IO;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    Console.WriteLine("{0, -30}\t directory", d.Name);
                }

                foreach (FileInfo f in dir.GetFiles())
                {
                    Console.WriteLine("{0, -30}\t File", f.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
