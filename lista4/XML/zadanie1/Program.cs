using System;
using System.IO;
using System.Xml.Serialization;

namespace zadanie1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Jan",
                Surname = "Kowalski",
                Gender = Gender.HELICOPTER,
                BirthDate = new DateTime(1999, 12, 6)
            };
            var xmlFormat = new XmlSerializer(typeof(Person));

            using Stream fStream = new FileStream("Osoba.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            xmlFormat.Serialize(fStream, person);
        }
    }
}
