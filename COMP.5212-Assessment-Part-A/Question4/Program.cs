using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person1 Person1 = new Person1("", "", "");
            Console.WriteLine("Please enter the new person below:");

            Console.WriteLine("First Name: ");
            Person1.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name");
            Person1.LastName = Console.ReadLine();

            Console.WriteLine("Enter year of birth");
            Person1.YearOfBirth = Console.ReadLine();

            GetFullName(FirstName, LastName);
        }
    }
}
