using System;
using System.Xml.Serialization;

namespace zadanie2
{

    [Serializable]
    public class Person
    {
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "Imie")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Nazwisko")]
        public string Surname { get; set; }

        [XmlAttribute(AttributeName = "Adres")]
        public string Address { get; set; }

        [XmlAttribute(AttributeName = "NumerTelefonu")]
        public string PhoneNumber { get; set; }

        public Person(int id, string name, string surname, string address, string phoneNumber)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public Person() { }

        public override string ToString()
        {
            return $"{Id}. {Name} {Surname} {Address} {PhoneNumber}";
        }
    }
}
