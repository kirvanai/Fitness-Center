
using System.Security.Cryptography.X509Certificates;

namespace Fitness_Center.Models
{
    public class MultiClubMember : Member
    {
        public int PointsEarned { get; set; } = 0;

        public List<Club> Clubs { get; set; }

        public MultiClubMember()
        {

        }

        public MultiClubMember( string name, List<Club> clubs) : base( name)
        {
            ID = 1000 + Members.Count;
            Name = name;
            Clubs = clubs;

        }

        public override void CheckIn(Member member, string input)
        {
            MultiClubMember multiClubMember = new MultiClubMember();
            multiClubMember = (MultiClubMember)member;
            Console.WriteLine($"Thanks for checking into the {input}");
            PointsEarned++;
              

        }

        public override double CalculateFee()
        {
            double output = 0;
            for (int i = 0;i < Clubs.Count;i++)
            {
                output = output + Clubs[i].Fee;
            }
            return output;
        }

    }


}
