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
            string loop = "y";
            while(loop == "y"||loop == "Y")
            { 
                Person1 person1 = new Person1("", "");
                Console.WriteLine("Please enter the new person below:\n");

                var people = new List<Person1>();
                
                Console.WriteLine("Enter your first name: ");
                person1.FirstName = Console.ReadLine();

                Console.WriteLine("Enter your last name: ");
                person1.LastName = Console.ReadLine();

                Console.WriteLine("Enter year of birth");
                person1.YearOfBirth = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nPerson: {person1.GetFullName()} is {person1.GetAge()} years old");

                people.Add(new Person1(person1.FirstName, person1.LastName));

                Console.WriteLine("Would you like too add another person? y or press any other key to exit");
                loop = Console.ReadLine();
            }
        }
    }
}
