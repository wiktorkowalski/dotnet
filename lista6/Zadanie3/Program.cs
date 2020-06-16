using System;
using System.Linq;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            context.Database.EnsureCreated();

            var osoby = context.Osoby.Select(item => item).ToList();

            osoby.ForEach(item => Console.WriteLine(@"
                *********************************
                Wiadomość do {0}
                {1}
                {2}
                Treść
                *********************************", item.Email,item.Imie, item.Nazwisko));
        }
    }
}
