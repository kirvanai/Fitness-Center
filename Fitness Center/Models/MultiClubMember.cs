
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
<<<<<<< HEAD
            ID = Member.Members == null ? 1000 : ID = 1000 + Members.Count;
=======
>>>>>>> 16501aab4817900c1c8064e9005c3c5a98f809a7
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
<<<<<<< HEAD
        {
           
=======
        {           

>>>>>>> 16501aab4817900c1c8064e9005c3c5a98f809a7
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