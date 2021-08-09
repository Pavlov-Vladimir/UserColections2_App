using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree_App
{
    class Person
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        Person[] _parents = null;
        Person[] _children = null;

        public Person(string name, int yearOfBirth)
        {
            Name = name;
            YearOfBirth = yearOfBirth;
        }

        public void AddParent(Person person)
        {
            if (_parents == null)
                _parents = new Person[2] { person, null };
            if (_parents[0] != null && _parents[1] != null)
                throw new Exception("Too many parents...");

            for (int i = 0; i < _parents.Length; i++)
            {
                if (_parents[i] == null)
                {
                    _parents[i] = person;
                    return;
                }
            }
        }

        public void AddChild(Person person)
        {
            if (_children == null)
                _children = new Person[] { person };
            else
            {
                Person[] people = new Person[_children.Length + 1];
                for (int i = 0; i < _children.Length; i++)
                    people[i] = _children[i];
                people[^1] = person;
                _children = people;
            }
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return (p1.Name == p2.Name && p1.YearOfBirth == p2.YearOfBirth);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return (p1.Name != p2.Name && p1.YearOfBirth != p2.YearOfBirth);
        }

        public override bool Equals(object obj)
        {
            if (obj is Person person)
                return (this.Name == person.Name && this.YearOfBirth == person.YearOfBirth);
            return false;
        }

        public override int GetHashCode()
        {
            return (Name.GetHashCode() ^ YearOfBirth.GetHashCode());
        }
    }
}
