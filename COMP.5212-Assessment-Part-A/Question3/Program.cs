using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Console.WriteLine("Enter new car details");
        
            Console.WriteLine("Car colour: ");
            Car1.Colour = Console.ReadLine();

            Console.WriteLine("Car Make: ");
            Car1.Make = Console.ReadLine();

            Console.WriteLine("Gearbox type: ");
            Car1.Gearbox = Console.ReadLine();

            Console.WriteLine($"This car is a {Car1.Colour} {Car1.Make} with a {Car1.Gearbox} transmission");
        }
    }
}
