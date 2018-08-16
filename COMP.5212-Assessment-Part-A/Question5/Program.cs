using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(" ", " ", " ");
            Console.WriteLine("Please enter the details for the new student");
            Console.WriteLine("Enter First Name: ");
            student1.FirstName = Console.ReadLine();
            Console.WriteLine("\nEnter Last Name: ");
            student1.LastName = Console.ReadLine();
            Console.WriteLine("\nEnter Campus");
            student1.Campus = Console.ReadLine();
            Console.WriteLine($"\n{student1.FirstName} {student1.LastName} of {student1.Campus} has a student ID of: {student1.EnrollStudent()}");

        }
    }
}
