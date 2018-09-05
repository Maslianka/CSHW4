using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth
{
    class Person
    {
        public Person()
        {
        }
        public Person(string n, DateTime b)
        {
            name = n;
            birthYear = b;
        }
        private string name;
        private DateTime birthYear;
        public string Name { get { return name; } }
        public DateTime BirthYear { get { return birthYear; } }

        public int Age()
        {
            return DateTime.Today.Year - birthYear.Year;

        }

        public void Input()
        {
            Console.Write("Enter person name: ");
            name = Console.ReadLine();
            Console.Write("Enter person birthday (yyyy): ");
            birthYear = DateTime.ParseExact(Console.ReadLine(), "yyyy", null);
        }

        public void ChangeName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Person name: {name}. \nPerson age {Age()}";
        }

        public void Output()
        {
             Console.WriteLine(ToString());
        }

        public static bool operator ==(Person a, Person b)
        {
            if (a.name == b.name) return true;
            return false;
        }
        public static bool operator !=(Person a, Person b)
        {
            if (a.name != b.name) return false;
            return true;
        }

    }
}
