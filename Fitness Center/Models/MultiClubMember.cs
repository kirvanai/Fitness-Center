
namespace Fitness_Center.Models
{
    public class MultiClubMember : Member
    {
        public int PointsEarned { get; set; } = 0;


        public MultiClubMember()
        {

        }

        public MultiClubMember( string name) : base( name)
        {
            Name = name;
        }

        public override void CheckIn(Member member, string clubName)
        {
            MultiClubMember multiClubMember = new MultiClubMember();
            multiClubMember = (MultiClubMember)member;
            Console.WriteLine($"Thanks for checking into the {clubName}");
            PointsEarned++;
        }

        public override double CalculateFee()
        {           

            double output = 0;

            for (int i = 0;i < Club.Clubs.Count;i++)
            {
                output = output + Club.Clubs[i].Fee;
            }

            output = output * 0.75;

            return output;

        }
    }
}