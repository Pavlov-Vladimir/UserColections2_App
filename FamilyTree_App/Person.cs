﻿using System;

namespace FamilyTree_App
{
    class Person
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        Person[] _parents = new Person[0];
        Person[] _children = new Person[0];

        public Person(string name, int yearOfBirth)
        {
            Name = name;
            YearOfBirth = yearOfBirth;
        }

        public void AddParent(Person person)
        {
            if (_parents.Length == 2 && _parents[0] != null && _parents[1] != null)
                return;
            Person[] people = new Person[_parents.Length + 1];
            for (int i = 0; i < _parents.Length; i++)
            {
                if (_parents[i] == person)  // Check for existing
                    return;
                people[i] = _parents[i];
            }
            people[^1] = person;
            _parents = people;
            person.AddChild(this);
        }

        public void AddChild(Person person)
        {
            Person[] people = new Person[_children.Length + 1];
            for (int i = 0; i < _children.Length; i++)
            {
                if (_children[i] == person)  // Check for existing
                    return;
                people[i] = _children[i];
            }
            people[^1] = person;
            _children = people;
            person.AddParent(this);
        }

        public void GetParents()
        {
            if (_parents.Length == 0)
                Console.WriteLine("has no parents.");
            else
            {
                foreach (Person person in _parents)
                    Console.WriteLine(person);
            }
        }

        public void GetChildren()
        {
            if (_children.Length == 0)
                Console.WriteLine("has no children.");
            else
            {
                foreach (Person person in _children)
                    Console.WriteLine(person);
            }
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return (p1?.Name == p2?.Name && p1?.YearOfBirth == p2?.YearOfBirth);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return (p1?.Name != p2?.Name && p1?.YearOfBirth != p2?.YearOfBirth);
        }

        public override string ToString()
        {
            return $"{Name}, born in {YearOfBirth}";
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
