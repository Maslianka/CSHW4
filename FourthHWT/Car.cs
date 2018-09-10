using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthHWT
{
    class Car
    {
        private string name;
        private string color;
        private double price;
        public const string CompanyName= "Mercedes";

        public Car() { }
        public Car(string carName, string carColor, double carPrice)
        {
            this.name = carName;
            color = carColor;
            price = carPrice;
        }


        public void Input()
        {
            Console.Write("Enter car name:");
            name = Console.ReadLine();

            Console.Write("Enter color:");
            color = Console.ReadLine();

            Console.Write("Enter price:");
            price = double.Parse(Console.ReadLine());
            
        }
        public void Print()
        {
            Console.WriteLine("\nYou wrote:");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Price: {0}", price);
        }

        public void ChangePrice(double x)
        {
            price = price - (price * (x / 100));
        }

        public static bool operator ==(Car a, Car b)
        {
            return a.name.Equals(b.name) && Math.Round(a.price, 2).Equals(Math.Round(b.price, 2));
        }

        public static bool operator !=(Car a, Car b)
        {
            return !a.name.Equals(b.name) && Math.Round(a.price, 2).Equals(Math.Round(b.price, 2));
        }

        public override string ToString()
        {
            return ("Car " + name + " " + "Color " + color + " " + "Price " + price);
        }
    }
}
