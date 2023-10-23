using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Center.Models
{
    public static class Validator
    {
        public static int GetValidMenuInput(string input)
        {
            try
            {
                int output = int.Parse(input);
                while (output > 4 && output < 1)
                {
                    Console.WriteLine("Invalid input. Please enter 1 - 4.");
                    input = Console.ReadLine();
                    GetValidMenuInput(input);
                }

                return output;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter 1 - 4.");
                input = Console.ReadLine();
                GetValidMenuInput(input);

            }
            return -1; //Make C# happyyyy
        }

        //public static int GetValidIdInput(string input)
        //{

        //}

        public static string GetValidYesNoInput(string input2)
        {
            bool isValidInput = false;

            do
            {
               
                if (input2 == "yes")
                {
                    return input2;
                }
                else if (input2 == "no")
                {
                    return input2;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                    input2 = Console.ReadLine().ToLower().Trim();
                    GetValidYesNoInput(input2);
                }
            } while (!isValidInput);

            return input2;
        }
    }
}
