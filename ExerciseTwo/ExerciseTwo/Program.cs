using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    internal class Program
    {
        static string userName, IdentificationNumber;
        static char gender;
        static int age, monthlySalary;
        static bool IsProgrammer;

        static void Main(string[] args)
        {
            GetUserInformation();
            Console.Clear();
            OutputConcatenation();
            Console.WriteLine();
            PlaceHolders();
            Console.WriteLine();
            StringInterpolation();

            Console.ReadKey();
        }

        static void StringInterpolation()
        {
            Console.WriteLine("String Interpolation Output");
            Console.WriteLine();
            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"ID: {IdentificationNumber}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Programmer: {IsProgrammer}");
            Console.WriteLine($"Salary: {monthlySalary}");
        }

        static void PlaceHolders()
        {
            Console.WriteLine("Place Holders Output");
            Console.WriteLine();
            Console.WriteLine("Name: {0}", userName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("ID: {0}", IdentificationNumber);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Programmer: {0}", IsProgrammer);
            Console.WriteLine("Salary: {0}", monthlySalary);
        }

        static void GetUserInformation()
        {
            Console.Write("What is your name: ");
            userName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("How old are you?: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter your Identification Number: ");
            IdentificationNumber = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Indicate you gender with M or F: ");
            gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Are you a programmer (true or false)?: ");
            IsProgrammer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();

            Console.Write("What are your monthly salary ?: ");
            monthlySalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        static void OutputConcatenation()
        {
            Console.WriteLine("Output Concatenation OutPut");
            Console.WriteLine();
            Console.WriteLine("Name: " + userName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("ID: " + IdentificationNumber);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Programmer: " + IsProgrammer);
            Console.WriteLine("Salary: " + monthlySalary);
        }
    }
}
