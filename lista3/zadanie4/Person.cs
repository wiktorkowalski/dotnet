using System;

namespace zadanie4
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Person(int id, string name, string surname, string address, string phoneNumber)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{Id}. {Name} {Surname} {Address} {PhoneNumber}";
        }
    }
}
