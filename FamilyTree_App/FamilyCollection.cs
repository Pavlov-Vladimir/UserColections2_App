using System;
using System.Collections;
using System.Collections.Generic;

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
            if (Contains(person))
                return;

            T[] people = new T[Count + 1];
            for (int i = 0; i < Count; i++)
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
            for (int i = 0; i < Count; i++)
                if (_family[i] == person)
                    return true;
            return false;
        }

        public int IndexOf(T person)
        {
            for (int i = 0; i < Count; i++)
                if (_family[i] == person)
                    return i;
            return -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = 0; i < Count; i++)
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

        public void GetPeopleBornAfter(int year)
        {
            foreach (T person in _family)
                if (person.YearOfBirth > year)
                    Console.WriteLine(person);
        }

        public void GetPeopleBornBefor(int year)
        {
            foreach (T person in _family)
                if (person.YearOfBirth < year)
                    Console.WriteLine(person);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _family[i];
            }
        }

        public bool Remove(T person)
        {
            if (Contains(person) == false)
                return false;
            T[] people = new T[Count - 1];
            for (int i = 0, j = 0; i < Count; i++, j++)
            {
                if (_family[i] == person)
                    i++;
                people[j] = _family[i];
            }
            _family = people;
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
