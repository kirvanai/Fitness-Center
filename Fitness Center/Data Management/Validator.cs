namespace Fitness_Center.Models
{
    public static class Validator
    {
        public static int GetValidMenuInput()
        {

            int validNumber = 0;
            bool redoLoop = true;


            while (redoLoop)
            {

                if (!int.TryParse(Console.ReadLine().Trim(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > 6))
                {                    
                    Console.WriteLine($"Enter a valid number between 1 and 6.");

                    redoLoop = true;             
                    
                }

                else
                {
                    redoLoop = false;
                }

            }

            return validNumber;

        }

        public static int GetValidClubInput()
        {

            int validNumber = 0;
            bool redoLoop = true;


            while (redoLoop)
            {

                if (!int.TryParse(Console.ReadLine().Trim(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > 4))

                {
                    Console.WriteLine($"Enter a valid number between 1 and 4.");

                    redoLoop = true;

                }

                else
                {
                    redoLoop = false;
                }


            }
            return validNumber; 


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