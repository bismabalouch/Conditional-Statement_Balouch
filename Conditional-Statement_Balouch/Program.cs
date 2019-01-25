/*
 Author: Bisma Balouch
 Date: 01/24/2019 
 Comments: This C# code demonstrates grades based on user input  
*/

using System;

namespace Conditional_Statement_Balouch
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for input 
            Console.WriteLine("What grade do you expect to recieve in ISM 4300? Please enter below.");

            //using try catch to ensure that right grade is displayed

            try
            {
                //decalring variable 
                string input = Console.ReadLine();

                //parsing the variable
                int input_value = int.Parse(input);


                //writing conditional statements to ensure that the code dispays the accurate grade
                //according to the user input 

                //conditional statement for A+
                if ((input_value >= 98) && (input_value <= 100))
                {
                    Console.WriteLine("Your grade for ISM 4300 is A+");

                }

                //conditional statement for A
                else if ((input_value >= 92) && (input_value <= 97))
                {
                    Console.WriteLine("Your grade for ISM 4300 is A");
                }
                
                //conditional statement for A-
                else if ((input_value >= 90) && (input_value <= 91))
                {
                    Console.WriteLine("Your grade for ISM 4300 is A-");
                }
                
                //conditional statement for B+
                else if ((input_value >= 88) && (input_value <= 89))
                {
                    Console.WriteLine("Your grade for ISM 4300 is B+");
                }

                //conditional statement for B
                else if ((input_value >=82) && (input_value <= 87))
                {
                    Console.WriteLine("Your grade for ISM 4300 is B");
                }
                
                //conditional statement for B-
                else if ((input_value >=80) && (input_value <= 81))
                {
                    Console.WriteLine("Your grade for ISM 4300 is B-");
                }
                
                //conditional statement for C+
                else if ((input_value >=78) && (input_value <= 79))
                {
                    Console.WriteLine("Your grade for ISM 4300 is C+");
                }

                //conditional statement for C
                else if ((input_value >=72) && (input_value <= 77))
                {
                    Console.WriteLine("Your grade for ISM 4300 is C");
                }

                //conditional statement for C-
                else if ((input_value >=70) && (input_value <= 71))
                {
                    Console.WriteLine("Your grade for ISM 4300 is C-");
                }

                //condtitional statement for D+
                else if ((input_value >= 68) && input_value <= 69)
                {
                    Console.WriteLine("Your grade for ISM 4300 is D+");
                }

                //conditional statement for D
                else if ((input_value >= 62) && (input_value <= 67))
                {
                    Console.WriteLine("Your grade for ISM 4300 is D");
                }

                //conditional statement for D-
                else if ((input_value >=60) && (input_value <= 61))
                {
                    Console.WriteLine("Your grade for ISM 4300 is D-");
                }

                //conditional statement where it checks when all other conditional requirements have failed 
                else 
                {
                    Console.WriteLine("Your grade for ISM 4300 is F");
                }

                Console.WriteLine();
                Console.ReadKey(true);
            } //end of try

            catch
            {
                Console.WriteLine("Please enter an integar value to get the letter grade");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            } //end of catch
        }
    }
}
