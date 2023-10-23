using Fitness_Center.Models;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Fitness_Center
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int menuInput;
            int memID =1000;

            string? nameInput;
            int clubNum =0;
            string? checkininput;
            
            Data data = new Data();
            data.DataSetup();

            Console.WriteLine("Welcome to 4 guys 4 clubs. Please enter your name");
            Console.WriteLine("Please enter your name:");
            nameInput = Validator.GetValidName(Console.ReadLine());
            Member memberDetails = Member.Members.FirstOrDefault(m => m.Name == nameInput);
            Console.WriteLine("Are you currently a member? (yes/no)");
            string input2 = Validator.GetValidYesNoInput(Console.ReadLine());
            if (input2 == "yes")
            {
                memID = memberDetails.ID;
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

                    if (input2 == "yes")
                    {
                        Console.WriteLine("You are already a member!");
                        break;
                    }
                    
                    Console.WriteLine("What type of membership? 'single' or 'multi'?");

                    string input3 = Validator.GetValidSingle(Console.ReadLine().ToLower().Trim());
                    if (input3 == "single")
                    {
                        for (int i = 0; i < Club.Clubs.Count; i++)
                        {
                            Console.WriteLine($"{i+1}.{Club.Clubs[i].Name}");
                        }

                        Console.WriteLine("Which club would you like to join?");
                        clubNum = Validator.GetValidMenuInput(Console.ReadLine());                                     
                        SingleClubMember memNew = new SingleClubMember(nameInput, Club.Clubs[clubNum - 1].Name);
                        memNew.AddMember(memNew);

                    }
                    else
                    {
                        MultiClubMember memNew = new MultiClubMember(nameInput);
                        memNew.AddMember(memNew);

                    }

                    break;
                case 2:

                    if (input2 == "no")
                    {
                        Console.WriteLine("You are not currently a member. Cannot cancel a membership.");
                    }

                    memberDetails.RemoveMember(memberDetails);

                    break;

                case 3:

                    if (input2 == "no")
                    {
                        Console.WriteLine("You are not a member currently.");
                        break;
                    }

                    Console.WriteLine("Please enter club name");
                    string clubName = (Console.ReadLine().Trim());
                      
                    var memberCheckin = Member.Members.FirstOrDefault(m => m.Name == nameInput);
                    memberCheckin.CheckIn(memberCheckin, clubName);        

                    break;

                case 4:
                    
                    if (input2 == "no")
                    {
                        Console.WriteLine("You are not a member currently.");
                        break;
                    }
                    var memberFee = Member.Members.FirstOrDefault(m => m.Name == nameInput);
                    Console.WriteLine(memberFee.CalculateFee().ToString("C", CultureInfo.CurrentCulture)); 
                    break;

            }
        }
    }
}