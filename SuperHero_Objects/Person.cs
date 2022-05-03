using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Objects
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            Name = "Kent";
            Surname = "Strong";
        }
        public Person(string name, string surname)
        {
            Name=name;
            Surname=surname;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\n Surname: {Surname}");
        }
    }
}
