namespace Fitness_Center.Models
{
    public static class Validator
    {
        public static int GetValidMenuInput(string input)
        {

            try
            {
                int output = int.Parse(input);
                while (output > 6 || output < 1)
                {
                    Console.WriteLine("Invalid input. Please enter 1 - 6.");
                    input = Console.ReadLine();
                    output = int.Parse(input);

                }
                return output;

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter 1 - 6.");
                input = Console.ReadLine();
                
            }
                return GetValidMenuInput(input);

        }

        public static int GetValidClubInput(string input)
        {

            try
            {
                int output = int.Parse(input);
                while (output > 4 || output < 1)
                {
                    Console.WriteLine("Invalid input. Please enter 1 - 4.");
                    input = Console.ReadLine();
                    output = int.Parse(input);

                }

                return output;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter 1 - 6.");
                input = Console.ReadLine();

            }
            return GetValidClubInput(input);

             
        
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
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid name. Please enter a valid name.");
                input = Console.ReadLine().Trim();
            }
            return input;
        }

    }

}