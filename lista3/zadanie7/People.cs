using System.Collections;
using System.Linq;

namespace zadanie7
{
    public class People : IEnumerator, IEnumerable
    {
        private readonly Person[] _people;
        int position = -1;

        public People(Person[] personArray)
        {
            _people = new Person[personArray.Length];
            personArray.CopyTo(_people, 0);
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }
        public void Reset()
        {
            position = 0;
        }

        public object Current
        {
            get { return _people[position]; }
        }
    }
}