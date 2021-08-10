using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree_App
{
    class FamilyCollection<T> : ICollection<T> where T : Person
    {
        private T[] _family;

        public int Count => _family.Length;
        public bool IsReadOnly => false;

        public FamilyCollection()
        {
            _family = Array.Empty<T>();
        }

        public void Add(T person)
        {
            T[] people = new T[_family.Length + 1];
            for (int i = 0; i < _family.Length; i++)
                people[i] = _family[i];

            people[^1] = person;
            _family = people;
        }

        public void Clear()
        {
            _family = Array.Empty<T>();
        }

        public bool Contains(T person)
        {
            for (int i = 0; i < _family.Length; i++)
                if (_family[i] == person)
                    return true;
            return false;
        }

        public int IndexOf(T person)
        {
            for (int i = 0; i < _family.Length; i++)
                if (_family[i] == person)
                    return i;
            return -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = 0; i < _family.Length; i++)
                array[arrayIndex++] = _family[i];
        }

        public void GetHeirs(T person)
        {
            if (Contains(person))
                person.GetHeirs();
            else
                Console.WriteLine($"{person.Name} is not exist in family.");
        }

        public void GetAncestors(T person)
        {
            if (Contains(person))
                person.GetAncestors();
            else
                Console.WriteLine($"{person.Name} is not exist in family.");
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _family.Length; i++)
            {
                yield return _family[i];
            }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
