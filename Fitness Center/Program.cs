﻿using Fitness_Center.Models;
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

            Console.WriteLine();
            Console.WriteLine("Welcome to 4 guys 4 clubs. Please enter your name");
            Console.WriteLine();
            Console.WriteLine("Please enter your name:");
            nameInput = Validator.GetValidName(Console.ReadLine());

            if(nameInput == "pizza the hutt")
            {
                Console.WriteLine("YOU CAN NEVER OUT PIZZA THE HUTT");
            }

            Console.WriteLine($"You entered: {nameInput}. Is this Correct? yes/no");
            string namecheck = Validator.GetValidYesNoInput(Console.ReadLine().ToLower().Trim());
            if (namecheck == "no" ) 
            {
                Console.WriteLine("Please enter correct name:");
                nameInput = Validator.GetValidName(Console.ReadLine());
            }
            
                

            

            Member currentMember = Member.Members.FirstOrDefault(m => m.Name.ToLower() == nameInput.ToLower());

            if (currentMember != null)
            {
                Console.WriteLine($"Member ID: {currentMember.ID}");
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

                    Console.WriteLine("1. Start a new membership.");
                    Console.WriteLine("2. Cancel a membership.");
                    Console.WriteLine("3. Check in with your membership.");
                    Console.WriteLine("4. See your current membership information.");
                    Console.WriteLine("5. Change Member");
                    Console.WriteLine("6. Exit.");

                    menuInput = Validator.GetValidMenuInput(Console.ReadLine());

                }

                switch (menuInput)
                {
                    case 1:

                        Console.WriteLine();

                        Console.WriteLine("What type of membership? 'single' or 'multi'");

                        Console.WriteLine();

                        string input3 = Validator.GetValidSingle(Console.ReadLine().ToLower().Trim());
                        if (input3 == "single")
                        {
                            for (int i = 0; i < Club.Clubs.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}.{Club.Clubs[i].Name}");
                            }

                            Console.WriteLine("Which club would you like to join?");
                            clubNum = Validator.GetValidClubInput(Console.ReadLine());
                            SingleClubMember memNew = new SingleClubMember(nameInput, Club.Clubs[clubNum - 1].Name);
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

                        string confirmCancellation;
                        Console.WriteLine("Are you sure you want to cancel your membership? yes/no");
                        confirmCancellation = Console.ReadLine();
                        Validator.GetValidYesNoInput(confirmCancellation);

                        if (confirmCancellation == "yes")
                        {
                            currentMember.RemoveMember(currentMember);
                            Console.WriteLine("Your membership has been cancelled. We are sorry to see you go.");

                        }
                        else
                        {
                            Console.WriteLine("Thank you for not cancelling your membership.");
                        }

                        Console.WriteLine("Please enter your name:");
                        nameInput = Validator.GetValidName(Console.ReadLine());

                        currentMember = Member.Members.FirstOrDefault(m => m.Name.ToLower() == nameInput.ToLower());

                        Console.WriteLine();


                        break;

                    case 3:

                        for (int i = 0; i < Club.Clubs.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{Club.Clubs[i].Name}");
                        }

                        Console.WriteLine("Please enter club number.");
                        int clubNumber = (Validator.GetValidClubInput(Console.ReadLine().Trim()));

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

                    case 10:

                        Console.WriteLine("YOU WILL NEVER OUT PIZZA THE HUT");

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