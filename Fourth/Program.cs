using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] person = new Person[3];
            for (int i = 0; i < person.Length; i++)
            {
                person [i] = new Person();
                person[i].Input();
            }

            foreach (var s in person)
            {
                if(s.Age()<16)
                {
                    s.ChangeName("Very Young");
                }
                s.Output();
            }
                        
            for (int i = 0; i < person.Length; i++)
            {
                for (int j = 0; j < person.Length; j++)
                {
                    if (j == i) continue;
                    if (person[i].Name == person[j].Name)
                    {
                        Console.WriteLine("This person has the same name: ");
                        person[i].Output();
                    }
                }
            }
            Console.Read();


        }
    }   
}
