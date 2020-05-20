using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace zadanie5
{
    [Serializable]
    public class People
    {
        [XmlArray("Osoby"), XmlArrayItem(typeof(Person), ElementName = "Osoba")]
        public List<Person> PeopleList { get; set; }
    }
}
