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

        public static string GetValidYesNoInput(string input2)
        {

            while (input2 != "yes" && input2 != "no")
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                input2 = Console.ReadLine().ToLower().Trim();
            }
            return input2;
                    
        }

        public static string GetValidSingle(string input2)
        {
            while (input2 != "single" && input2 != "multi")
            {
                Console.WriteLine("Invalid input. Please enter 'single' or 'multi'.");
                input2 = Console.ReadLine().ToLower().Trim();
            }
            return input2;
        }

        public static string GetValidName(string input)
        {
            while (string.IsNullOrWhiteSpace(input) || !IsNameValid(input))
            {
                Console.WriteLine("Invalid name. Please enter a valid name.");
                input = Console.ReadLine().Trim();
            }
            return input;
        }
        public static bool IsNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }


            if (name.Any(char.IsDigit) || name.Any(char.IsPunctuation) || name.Any(char.IsSymbol))
            {
                return false;
            }

            string lowerName = name.ToLower();


            return Member.Members.Any(member => member.Name.ToLower() == lowerName);
        }

    }
}
