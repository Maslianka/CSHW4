using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthHWT
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Car.CompanyName);
            List<Car> cars = new List<Car>();
            cars.Add( new Car("s200","black",90000));
            cars.Add(new Car("s500", "white", 190000));
            cars.Add(new Car("SLS", "black", 5000000));
           
            

            foreach(var s in cars)
            {
                s.ChangePrice(10);
            }
            foreach (var s in cars)
            {
                s.Print();
            }
           
            Console.ReadKey();
        }
    }
}
