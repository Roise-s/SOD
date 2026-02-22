using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    internal class Program
    {
        static string studentName = "Nel", courseName = "DP_ITC";
        static double courseAmount = 15123.99;

        static void Main(string[] args)
        {
            Console.WriteLine("Displaying the concatenation output");
            OutputConcatenation();
            Console.WriteLine();
            Console.WriteLine("Displaying the place holders output");
            PlaceHolders();
            Console.WriteLine();
            Console.WriteLine("Displaying the string interpolation output");
            StringInterpolation();
            Console.WriteLine();

            Console.ReadKey();
        }

        static void StringInterpolation()
        {
            Console.WriteLine($"{studentName} study {courseName} costing {courseAmount}");
        }

        static void PlaceHolders()
        {
            Console.WriteLine("{0} study {1} costing {2}", studentName, courseName, courseAmount);
        }

        static void OutputConcatenation()
        {
            Console.WriteLine(studentName + " study " + courseName + " costing R" + courseAmount);
        }
    }
}
