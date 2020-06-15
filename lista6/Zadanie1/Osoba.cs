using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Zadanie1
{
    class Osoba
    {
        [Key]
        public int Id { get; set; }

        [NotNull]
        public string Imie { get; set; }

        [NotNull]
        public string Nazwisko { get; set; }

        [NotNull]
        public int Wiek { get; set; }

        public override string ToString() => $"{Id}. {Imie} {Nazwisko} {Wiek}";
    }
}
