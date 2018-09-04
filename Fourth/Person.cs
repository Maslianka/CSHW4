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

        public Person Input()
        {
            Console.Write("Enter person name: ");
            name = Console.ReadLine();
            Console.Write("Enter person birthday (yyyy): ");
            birthYear = DateTime.ParseExact(Console.ReadLine(), "yyyy", null);
            return new Person(name, birthYear);
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

        public static bool operator ==(Person person1, Person person2)
        {
            return (person1.Name == person2.Name);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}
