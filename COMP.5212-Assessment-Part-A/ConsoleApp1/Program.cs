using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            Console.WriteLine("Enter new car details");

            Console.WriteLine("Car colour: ");
            car1.SetColour(Console.ReadLine());

            Console.WriteLine("Car Make: ");
            car1.SetMake(Console.ReadLine());

            Console.WriteLine("Gearbox type: ");
            car1.SetGearbox(Console.ReadLine());

            Console.WriteLine($"This car is a {car1.GetColour()} {car1.GetMake()} with a {car1.GetGearbox()} transmission");
        }
    }
}
