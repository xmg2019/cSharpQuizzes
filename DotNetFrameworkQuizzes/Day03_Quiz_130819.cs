using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkQuizzes
{
    // Day 03 Quiz
    // Write a program to calculate discount calculation for a gadget promotion. Each gadget is sold at $500. 
    // The discount should follow the following table:
    // $2000 < Amount <= $3000 , Discount = 3%
    // $3000 < Amount <= $6000 , Discount = 5%
    // $6000 < Amount , Discount = 3%

        // My Attempt:

    class Day03_Quiz_130819
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISS Gadget Shop");
            Console.WriteLine("Number of Items to Purchase = ");
            double X = Convert.ToDouble(Console.ReadLine());
            double X1 = (X * 500);

            

            if (X1 <= 2000 && X1 >= 500)
            {
                Console.WriteLine($"Please Pay $ {X1:0.00}");
            }
            if (X1 >2000 && X1<=3000)
            {
                Console.WriteLine($"Please pay $ {(X1 * 0.97):0.00}");
            }

            if (X1 > 3000 && X1 <= 6000)
            {
                Console.WriteLine($"Please pay $ {(X1 * 0.95):0.00}");
            }
            if (X1 > 6000)
            {
                Console.WriteLine($"Please pay $ {(X1 * 0.92):0.00}");
            }
        }
        

    }
}
