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

            bob.AddChild(vlad);
            bob.AddChild(tolik);
            bob.AddParent(pavlik);
            bob.AddParent(katja);

            Console.WriteLine(bob);
            Console.Write("Parents:\n");
            bob.GetParents();
            Console.WriteLine("---");
            Console.Write("Children:\n");
            bob.GetChildren();
            Console.WriteLine(new string('-', 40));

            Console.WriteLine(vlad);
            Console.Write("Parents:\n");
            vlad.GetParents();
            Console.WriteLine("---");
            Console.Write("Children:\n");
            vlad.GetChildren();
            Console.WriteLine(new string('-', 40));

            Console.WriteLine(tolik);
            Console.Write("Parents:\n");
            tolik.GetParents();
            Console.WriteLine("---");
            Console.Write("Children:\n");
            tolik.GetChildren();
            Console.WriteLine(new string('-', 40));

            Console.WriteLine(katja);
            Console.Write("Parents:\n");
            katja.GetParents();
            Console.WriteLine("---");
            Console.Write("Children:\n");
            katja.GetChildren();
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
