using Fitness_Center.Models;

namespace Fitness_Center
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to 4 guys 4 clubs. How can I assist you today?");
            Console.WriteLine("1. Start a new membership.");
            Console.WriteLine("2. Cancel a membership.");
            Console.WriteLine("3. Check in with your membership.");
            Console.WriteLine("4. See your current membership fee.");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("What type of membership? Single-club or Multi-club?");
                    string input2 = Console.ReadLine().ToLower().Trim();
                    if (input2 == "single-club")
                    {
                        Console.WriteLine("Please enter your name:");
                        string nameInput = Console.ReadLine();
                        
                        for (int i = 0; i < Club.Clubs.Count;  i++)
                        {

                        }
                        new SingleClubMember memNew = new SingleClubMember(nameInput,);
                    }
                    break;
                case 2:
                    //remove member
                    break;
                case 3:
                    //checkin
                    break;
                case 4:
                    //calculate fee
                    break;
                


            }

        }

    }
}

