using System.Collections;
using System.Linq;

namespace zadanie7
{
    public class People : IEnumerable
    {
        private readonly Person[] _people;

        public People(Person[] personArray)
        {
            _people = new Person[personArray.Length];
            personArray.CopyTo(_people, 0);
        }

        public IEnumerator GetEnumerator()
        {
            return _people.TakeWhile(person => person != null).GetEnumerator();
        }
    }
}