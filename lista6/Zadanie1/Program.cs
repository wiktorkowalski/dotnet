using System;
using System.Linq;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            context.Database.EnsureCreated();

            context.Osoby.Add(new Osoba
            {
                Imie = "test1",
                Nazwisko = "test2",
                Wiek = 1
            });

            context.SaveChanges();

            Console.WriteLine(context.Osoby.First().ToString());
        }
    }
}
