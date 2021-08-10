using System;

namespace FamilyTree_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new("Bob", 1979);
            Person vlad = new("Vlad", 2012);
            Person katja = new("Katja", 1956);
            Person pavlik = new("Pavlik", 1956);
            Person tolik = new("Tolik", 2007);
            Person marina = new("Marina", 1974);

            bob.AddChild(vlad);
            bob.AddChild(tolik);
            bob.AddParent(pavlik);
            bob.AddParent(katja);
            bob.AddSpouse(marina);

            Console.WriteLine(bob);
            Console.Write("Parents:\n");
            bob.GetParents();
            Console.WriteLine("---");
            Console.Write("Children:\n");
            bob.GetChildren();
            Console.WriteLine("---");
            Console.WriteLine("Spouse:");
            bob.GetSpouse();
            Console.WriteLine(new string('-', 40));

            Console.WriteLine(marina);
            Console.Write("Parents:\n");
            marina.GetParents();
            Console.WriteLine("---");
            Console.Write("Children:\n");
            marina.GetChildren();
            Console.WriteLine("---");
            Console.WriteLine("Spouse:");
            marina.GetSpouse();
            Console.WriteLine(new string('-', 40));

            Console.WriteLine(vlad);
            Console.Write("Parents:\n");
            vlad.GetParents();
            Console.WriteLine("---");
            Console.Write("Children:\n");
            vlad.GetChildren();
            Console.WriteLine(new string('-', 40));

            Console.WriteLine(pavlik);
            Console.Write("Parents:\n");
            pavlik.GetParents();
            Console.WriteLine("---");
            Console.Write("Children:\n");
            pavlik.GetChildren();
            Console.WriteLine(new string('-', 40));
        }
    }
}
