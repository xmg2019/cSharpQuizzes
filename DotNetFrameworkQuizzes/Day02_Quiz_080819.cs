using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkQuizzes
{
    // Day 2 Quiz
    // Write a program to convert length measurement from centimetre to inch. 
    // The measurement in inch can be calculated using the following formula:
    // Length in inch = Length in cm / 2.54
    // Format the result with three digits behind the decimal points (refer to the sample output as reference)

        // My Attempt:

    class Day02_Quiz_080819
    {
        static void Main(String[] args)
        {
            Console.Write("Please enter the length in cm: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Length in inch = {(number / 2.54): 0.000}");

        }
    }
}
