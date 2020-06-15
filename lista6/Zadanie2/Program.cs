using System;
using System.Linq;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            var query = context.Osoby.Select(item => item).Where(x => x.Imie.Contains("test")).ToList();

            query.ForEach(item => Console.WriteLine(item));
        }
    }
}
