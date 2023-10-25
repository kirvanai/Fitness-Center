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
            int clubNumber;

            string? nameInput;
            string? namecheck;
            string? inputSingleMulti;
            string? confirmCancellation;

            bool continueOn = true;

            ClubData data = new ClubData();
            data.DataSetup();

            Console.WriteLine();
            Console.WriteLine("Welcome to 4 guys 4 clubs. Please enter your name");
            Console.WriteLine();
            Console.WriteLine("Please enter your name:");
            nameInput = Validator.GetValidName(Console.ReadLine());

            if(nameInput == "pizza the hutt")
            {
                Console.WriteLine("YOU CAN NEVER OUT PIZZA THE HUTT");
            }
                        
            Member currentMember = Member.Members.FirstOrDefault(m => m.Name.ToLower() == nameInput.ToLower());

            if (currentMember != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Member ID: {currentMember.ID}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"You entered: {nameInput}. Is this how you want your name to appear on your membership? yes/no");
                namecheck = Validator.GetValidYesNoInput(Console.ReadLine().ToLower().Trim());
                
                if (namecheck == "no")
                {
                    Console.WriteLine("Please enter correct name:");
                    nameInput = Validator.GetValidName(Console.ReadLine());
                }

            }


            while (continueOn)
            {
                if (currentMember == null)
                {
                    menuInput = 1;
                    Console.WriteLine("We see you are not a current member. Starting a new membership.");
                }
                else
                {

                    Console.WriteLine("Please select from the following menu options:");

                    Console.WriteLine("1. Change membership type.");
                    Console.WriteLine("2. Cancel a membership.");
                    Console.WriteLine("3. Check in with your membership.");
                    Console.WriteLine("4. See your current membership information.");
                    Console.WriteLine("5. Change Member");
                    Console.WriteLine("6. Exit.");

                    menuInput = Validator.GetValidMenuInput();

                    Console.WriteLine();

                }

                switch (menuInput)
                {
                    case 1:
                        if (currentMember != null)
                        {
                            Member.Members.Remove(currentMember);
                        }
                        Console.WriteLine();

                        Console.WriteLine("What type of membership? 'single' or 'multi'");

                        Console.WriteLine();

                        inputSingleMulti = Validator.GetValidSingle(Console.ReadLine().ToLower().Trim());
                        if (inputSingleMulti == "single")
                        {
                            for (int i = 0; i < Club.Clubs.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}.{Club.Clubs[i].Name}");
                                Console.WriteLine();
                                Console.WriteLine($"{Club.Clubs[i].Address}");
                                Console.WriteLine($"{Club.Clubs[i].City} {Club.Clubs[i].State}, {Club.Clubs[i].ZipCode}");
                                Console.WriteLine();
                            }

                            Console.WriteLine("Which club would you like to join?");
                            clubNumber = Validator.GetValidClubInput();
                            SingleClubMember memNew = new SingleClubMember(nameInput, Club.Clubs[clubNumber - 1].Name);
                            memNew.AddMember(memNew);
                            currentMember = memNew;

                        }
                        else
                        {
                            MultiClubMember memNew = new MultiClubMember(nameInput);
                            memNew.AddMember(memNew);
                            currentMember = memNew;

                        }

                        Console.WriteLine();

                        break;

                    case 2:
                        
                        Console.WriteLine("Are you sure you want to cancel your membership? yes/no");
                        confirmCancellation = Console.ReadLine();
                        confirmCancellation = Validator.GetValidYesNoInput(confirmCancellation);

                        if (confirmCancellation == "yes")
                        {
                            currentMember.RemoveMember(currentMember);
                            Console.WriteLine("Your membership has been cancelled. We are sorry to see you go.");

                            Console.WriteLine();

                            Console.WriteLine("Please enter your name:");
                            nameInput = Validator.GetValidName(Console.ReadLine());

                            currentMember = Member.Members.FirstOrDefault(m => m.Name.ToLower() == nameInput.ToLower());

                            Console.WriteLine();

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Thank you for not cancelling your membership.");
                        }


                        Console.WriteLine();


                        break;

                    case 3:

                        for (int i = 0; i < Club.Clubs.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{Club.Clubs[i].Name}");
                            Console.WriteLine();
                            Console.WriteLine($"  {Club.Clubs[i].Address}");
                            Console.WriteLine($"  {Club.Clubs[i].City} {Club.Clubs[i].State}, {Club.Clubs[i].ZipCode}");
                            Console.WriteLine();
                        }

                        Console.WriteLine("Please enter club number.");
                        clubNumber = (Validator.GetValidClubInput());

                        currentMember.CheckIn(currentMember, Club.Clubs[clubNumber - 1].Name);

                        Console.WriteLine();

                        break;

                    case 4:

                        Console.WriteLine($"Member Id: {currentMember.ID}");
                        Console.WriteLine($"Member Name: {currentMember.Name}");
                        Console.WriteLine($"Club Fees: {currentMember.CalculateFee().ToString("C", CultureInfo.CurrentCulture)}");

                        if (currentMember.GetType() == typeof(MultiClubMember))
                        {
                            MultiClubMember multiMemberInfo = (MultiClubMember)currentMember;

                            Console.WriteLine($"Points Earned: {multiMemberInfo.PointsEarned}");
                        }
                        else
                        {
                            SingleClubMember singleClubMemberInfo = (SingleClubMember)currentMember;

                            Console.WriteLine($"You are a member of {singleClubMemberInfo.ClubName}");
                        }

                        Console.WriteLine();

                        break;

                    case 5:

                        Console.WriteLine("Please enter your name:");
                        nameInput = Validator.GetValidName(Console.ReadLine());

                        currentMember = Member.Members.FirstOrDefault(m => m.Name.ToLower() == nameInput.ToLower());

                        Console.WriteLine();

                        break;


                    default:

                        continueOn = false;

                        Console.WriteLine();

                        break;

                }

            }

        }

    }

}