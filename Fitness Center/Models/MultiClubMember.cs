
using System.Security.Cryptography.X509Certificates;

namespace Fitness_Center.Models
{
    public class MultiClubMember : Member
    {
        public int PointsEarned { get; set; }

        public List<Club> Clubs { get; set; }

        public MultiClubMember()
        {

        }

        public MultiClubMember(int id, string name, List<Club> clubs) : base(id, name)
        {
            ID = id;
            Name = name;
            Clubs = clubs;

        }

        public override void CheckIn(Member member, string input)
        {
            MultiClubMember multiClubMember = new MultiClubMember();
            multiClubMember = (MultiClubMember)member;

            for (int i = 0; i < Clubs.Count; i++)
            {
                if (multiClubMember.Clubs[i].Name.Contains(input))
                {
                    Console.WriteLine($"Thanks for checking into the {multiClubMember.Clubs[i].Name}");
                }
                else
                {
                    Console.WriteLine("Club not found under membership.");
                }
            }


        }

        public override void CalculateFee()
        {
            throw new NotImplementedException();
        }

    }


}
