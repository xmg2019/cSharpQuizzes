using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkQuizzes
{
    // Day 05 Quiz
    // Complete a program which will count the number of occurrence of an integer between 0-9 in a pre-defined two-dimensional array.
    // The program should:
    // - Ask user to pick a number
    // - Go through the array and count the occurrence of that number
    // - Display the result

        // My Attempt: 

    class Day05_Quiz_150819
    {
        static void Main (String[]args)
        {
            int[,] theArray = new int[,] { { 5, 3 }, { 2, 9 }, { 2, 9 }, { 5, 1 }, { 7, 1 }, { 8, 3 }, { 0, 3 }, { 2, 2 }, { 9, 7 } };
            int count = 0;

            Console.Write("Please enter a number (0-9): "); 
            int input = Convert.ToInt32(Console.ReadLine());

            for (int k=0; k<theArray.GetLength(0); k++)
            {
                for (int j=0; j<theArray.GetLength(1); j++)
                {
                    if (theArray[k,j] == input)
                    {
                        count++;                                         
                    }                
                }
            }
            Console.WriteLine("Total count of numerical occurance of the number " + input + " in the pre-defined array = " + count);
        }
    }
}
