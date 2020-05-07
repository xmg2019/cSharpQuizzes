using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameworkQuizzes
{
    // Day 04 Quiz
    // Write a program to perform PIN validation for the Bank of ISS. 
    // User account should be locked out if the user fails to enter the correct PIN within three tries. 
    // You can hardcode the PIN in your code (put it in a variable.)

        // My Attempt:

    class Day04_Quiz_140819
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the Bank of ISS");
            Console.Write("Please enter your PIN Password : ");
            int Entry = Convert.ToInt32(Console.ReadLine());

            // Console.Write shall always assign the input from user to the next line. So : PLS DO NOT JUMP LINE!!! //
            int PIN = 123456;
            int NUMENTRY = 0;
                                            
            while (Entry != PIN)

            {
                NUMENTRY++;

                if (Entry != PIN && NUMENTRY < 3)
                {
                    Console.WriteLine("Incorrect Password, Please try again : ");
                    Entry = Convert.ToInt32(Console.ReadLine());
                    
                }

                if (Entry != PIN && NUMENTRY > 3)
                {
                    Console.WriteLine("Too Many Wrong Entries. Your Account is now locked.");
                    Entry = Convert.ToInt32(Console.ReadLine());
                    
                }
                
                
            }
                    Console.Write("PIN accepted. You can access your account now.");
                    

        }

        }

    }



