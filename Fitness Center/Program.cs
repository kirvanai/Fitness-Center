using Fitness_Center.Models;
using System.Globalization;
using Fitness_Center.Data;

namespace Fitness_Center
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int menuInput = 0;
            int memID = 1000;
            int clubNum = 0;

            string? nameInput;            
            string? checkininput;

            bool continueOn = true;
            
            ClubData data = new ClubData();
            data.DataSetup();

            while (continueOn)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to 4 guys 4 clubs. Please enter your name");
                Console.WriteLine();
                Console.WriteLine("Please enter your name:");
                nameInput = Validator.GetValidName(Console.ReadLine());

                Member memberDetails = Member.Members.FirstOrDefault(m => m.Name == nameInput);

                if (memberDetails == null)
                {
                    menuInput = 1;
                    Console.WriteLine("We see you are not a current member. Starting a new membership.");
                }
                else
                {
                    memID = memberDetails.ID;

                    Console.WriteLine($"Member ID: {memID}");

                    Console.WriteLine("Please select from the following menu options:");

                    Console.WriteLine("1. Start a new membership.");
                    Console.WriteLine("2. Cancel a membership.");
                    Console.WriteLine("3. Check in with your membership.");
                    Console.WriteLine("4. See your current membership information.");
                    Console.WriteLine("5. Exit.");

                    menuInput = Validator.GetValidMenuInput(Console.ReadLine());

                }

                switch (menuInput)
                {
                    case 1:

                        Console.WriteLine();

                        Console.WriteLine("What type of membership? 'single' or 'multi'?");

                        Console.WriteLine();

                        string input3 = Validator.GetValidSingle(Console.ReadLine().ToLower().Trim());
                        if (input3 == "single")
                        {
                            for (int i = 0; i < Club.Clubs.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}.{Club.Clubs[i].Name}");
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

                        memberDetails.RemoveMember(memberDetails);

                        break;

                    case 3:

                        Console.WriteLine("Please enter club name");
                        string clubName = (Console.ReadLine().Trim());

                        var memberCheckin = Member.Members.FirstOrDefault(m => m.Name == nameInput);
                        memberCheckin.CheckIn(memberCheckin, clubName);

                        break;

                    case 4:
                       
                        Member memberFee = Member.Members.FirstOrDefault(m => m.Name == nameInput);

                        Console.WriteLine($"Member Id: {memberFee.ID}");
                        Console.WriteLine($"Member Name: {memberFee.Name}");
                        Console.WriteLine($"Club Fees: {memberFee.CalculateFee()}");

                        if (memberFee.GetType() == typeof(MultiClubMember))
                        {
                            MultiClubMember multiMemberInfo = (MultiClubMember)memberFee;

                            Console.WriteLine($"Points Earned: {multiMemberInfo.PointsEarned}");
                        }
                        else
                        {
                            SingleClubMember singleClubMemberInfo = (SingleClubMember)memberFee;

                            Console.WriteLine($"You are a member of {singleClubMemberInfo.ClubName}");
                        }

                        Console.WriteLine(memberFee.CalculateFee().ToString("C", CultureInfo.CurrentCulture));
                        break;

                    default:

                        continueOn = false;
                        break;

                }

            }
                        
        }
    
    }

}