using System;

namespace zadanie6
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(int id, string name, string surname, string address, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Address = address;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Id}. {Name} {Surname} {Address} {BirthDate}";
        }
    }
}
