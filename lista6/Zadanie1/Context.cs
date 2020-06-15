using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    class Context : DbContext
    {

        public DbSet<Osoba> Osoby { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseNpgsql("Host=localhost;Database=dotnet;Username=postgres;Password=postgres;Persist Security Info=True");

        }
    }
}

