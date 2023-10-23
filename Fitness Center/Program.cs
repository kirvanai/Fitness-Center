using Fitness_Center.Models;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Fitness_Center
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int menuInput;
            int memberId;


            string? nameInput;
            string? clubName;
            string? checkininput;

            Data data = new Data();
            data.DataSetup();

            Console.WriteLine("Welcome to 4 guys 4 clubs. Please enter your name");
            Console.WriteLine("Please enter your name:");
            nameInput = Console.ReadLine();

            Console.WriteLine("Are you currently a member? (yes/no)");
            string input2 = Validator.GetValidYesNoInput(Console.ReadLine());
            if (input2 == "yes")
            {
                var memberDetails = Member.Members.FirstOrDefault(m => m.Name == nameInput);
                int memID = memberDetails.ID;
                Console.WriteLine($"Member ID: {memID}");
            }


            Console.WriteLine("Please select from the following menu options:");

            Console.WriteLine("1. Start a new membership.");
            Console.WriteLine("2. Cancel a membership.");
            Console.WriteLine("3. Check in with your membership.");
            Console.WriteLine("4. See your current membership fee.");

            menuInput = Validator.GetValidMenuInput(Console.ReadLine());

            switch (menuInput)
            {
                case 1:

                    Console.WriteLine("What type of membership? Single-club or Multi-club?");

                    string input3 = Console.ReadLine().ToLower().Trim();
                    if (input3 == "single-club")
                    {
                        for (int i = 0; i < Club.Clubs.Count; i++)
                        {
                            Console.WriteLine(Club.Clubs[i].Name);
                        }

                        clubName = Console.ReadLine();

                        SingleClubMember memNew = new SingleClubMember(nameInput, clubName);

                    }
                    else
                    {
                        MultiClubMember memNew = new MultiClubMember(nameInput);

                    }

                    break;
                case 2:

                    Console.WriteLine("Enter the Id of the member you want to remove.");

                    memberId = int.Parse(Console.ReadLine());

                    Member.Members.RemoveAt(memberId);

                    break;

                case 3:                   
                   
                    Console.WriteLine("Please enter club name");
                    clubName = (Console.ReadLine().Trim());
                      
                    var memberCheckin = Member.Members.FirstOrDefault(m => m.Name == nameInput);
                    memberCheckin.CheckIn(memberCheckin, clubName);        

                    break;

                case 4:
                    var memberFee = Member.Members.FirstOrDefault(m => m.Name == nameInput);
                    memberFee.CalculateFee();
                    break;

            }
        }
    }
}