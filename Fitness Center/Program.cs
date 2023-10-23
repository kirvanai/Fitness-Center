﻿using Fitness_Center.Models;

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

            Console.WriteLine("Welcome to 4 guys 4 clubs. How can I assist you today?");
            Console.WriteLine("1. Start a new membership.");
            Console.WriteLine("2. Cancel a membership.");
            Console.WriteLine("3. Check in with your membership.");
            Console.WriteLine("4. See your current membership fee.");
            
            menuInput = int.Parse(Console.ReadLine());
            
            switch (menuInput)
            {
                case 1:

                    Console.WriteLine("Please enter your name:");
                    nameInput = Console.ReadLine();

                    Console.WriteLine("What type of membership? Single-club or Multi-club?");

                    string input2 = Console.ReadLine().ToLower().Trim();
                    if (input2 == "single-club")
                    {                                                
                        for (int i = 0; i < Club.Clubs.Count;  i++)
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

                    memberId =  int.Parse(Console.ReadLine());

                    Member.Members.RemoveAt(memberId);

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

