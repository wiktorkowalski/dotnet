using System;
using System.Xml.Serialization;

namespace zadanie1
{
    [Serializable]
    [XmlRoot(ElementName = "Osoba")]
    public class Person
    {
        [XmlElement(ElementName = "Imie")]
        public string Name { get; set; }
        
        [XmlElement(ElementName = "Nazwisko")]
        public string Surname { get; set; }

        [XmlElement(ElementName = "Plec")]
        public Gender Gender { get; set; }

        [XmlElement(ElementName = "DataUrodzenia")]
        public DateTime BirthDate { get; set; }
    }
}
