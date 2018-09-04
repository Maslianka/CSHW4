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
            List<Person> person = new  List<Person>();
            for (int i = 0; i < 1; i++)
            {
                person.Add(new Person().Input());
            }
            foreach(var s in person)
            {
                if(s.Age()<16)
                {
                    s.ChangeName("Very Young");
                }
                s.Output();
            }
            
            foreach(var l in person)
            {
                //if (l += l)
                //{

                //}
            }
            Console.ReadKey();
        }
    }   
}
