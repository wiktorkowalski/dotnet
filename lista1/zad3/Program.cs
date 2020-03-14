using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(args[0] ?? Directory.GetCurrentDirectory());

            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                Console.WriteLine("{0, -50}\t directory", d.Name);
            }

            foreach (FileInfo f in dir.GetFiles())
            {
                Console.WriteLine("{0, -50}\t File", f.Name);
            }

            Console.ReadKey();
        }
    }
}
