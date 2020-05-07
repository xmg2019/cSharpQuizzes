using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkQuizzes
{
    // Day 06 Quiz
    // Implementation of a pseudo tax calculator, using the tax bracket, minimum income & base payable arrays provided
    // Ask user for their income and return their calculated tax payable.

        // My Attempt: 

    class Day06_Quiz_160819
    {
        //these arrays is visible in all the static method, //so you can use them in your method implementation
        static int[] minIncomeArray = new int[] { 20000, 30000, 40000, 80000, 120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[] { 0.02, 0.035, 0.07, 0.115, 0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[] { 0, 200, 550, 3350, 7950, 13950, 20750, 42350 };

        static int AskForIncome ()
        {
            Console.WriteLine("Please enter your annual taxable income: $");
            int annualIncome = Convert.ToInt32(Console.ReadLine());

            return annualIncome;
        }

        static int GetTaxBracket(int annualIncome)
        {
            int taxBracket = 0;

            if (annualIncome > 0 && annualIncome < 20000)
            {
                taxBracket = -1;
            }
            else if (annualIncome >= 20000 && annualIncome < 30000)
            {
                taxBracket = 0;
            }
            else if (annualIncome >= 30000 && annualIncome < 40000)
            {
                taxBracket = 1;
            }
            else if (annualIncome >= 40000 && annualIncome < 80000)
            {
                taxBracket = 2;
            }
            else if (annualIncome >= 80000 && annualIncome < 120000)
            {
                taxBracket = 3;
            }
            else if (annualIncome >= 120000 && annualIncome < 160000)
            {
                taxBracket = 4;
            }
            else if (annualIncome >= 160000 && annualIncome < 200000)
            {
                taxBracket = 5;
            }
            else if (annualIncome >= 200000 && annualIncome < 320000)
            {
                taxBracket = 6;
            }
            else if (annualIncome >= 320000)
            {
                taxBracket = 7;
            }


            return taxBracket;
        }

        static double CalculateIncomeTax(int annualIncome, int taxBracket)
        {
            double taxPayable = 0;


            if (taxBracket == -1)
            {
                taxPayable = 0;
            }
            else if (taxBracket == 0)
            {
                taxPayable = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
            }
            else if (taxBracket == 1)
            {
                taxPayable = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
            }
            else if (taxBracket == 2)
            {
                taxPayable = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
            }
            else if (taxBracket == 3)
            {
                taxPayable = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
            }
            else if (taxBracket == 4)
            {
                taxPayable = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
            }
            else if (taxBracket == 5)
            {
                taxPayable = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
            }
            else if (taxBracket == 6)
            {
                taxPayable = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
            }
            else if (taxBracket == 7)
            {
                taxPayable = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
            }

            // Checks
            // Console.WriteLine(taxBracket);
            // Console.WriteLine(minIncomeArray[taxBracket]);
            // Console.WriteLine(taxRateArray[taxBracket]);
            // Console.WriteLine(basePayableAmountArray[taxBracket]);
            // Console.WriteLine(taxPayable);

            return taxPayable;
        }

        static void PrintResult(int income, double taxPayable)
        {
            Console.WriteLine($"For taxable annual income of ${income:0,0.00}, the tax payable amount is ${taxPayable:0,0.00}");
        }

        static void Main(string[] args)
        {
            // Get the taxable income from user
            int annualIncome = AskForIncome();

            // Get the tax bracket of the user
            int taxBracket = GetTaxBracket(annualIncome);

            // Calculate the taxable income based on the tax bracket
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);

            // Print the result
            PrintResult(annualIncome, taxPayable);
        }


    }
}
