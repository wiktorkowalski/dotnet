using System;

namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray =
            {
                new Person("Richard", "Brown"),
                new Person("Howard", "Gagnon"),
                new Person("Anthony", "Bulluck"),
                new Person("John", "Bukowski"),
                new Person("Katia", "Adams"),
            };

            var peopleList = new People(peopleArray);

            foreach (Person person in peopleList)
            {
                Console.WriteLine($"{person.firstName} {person.lastName}");
            }
        }
    }
}
