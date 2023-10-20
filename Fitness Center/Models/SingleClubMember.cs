
namespace Fitness_Center.Models
{
    public class SingleClubMember : Member
    {
        public Club Club {  get; set; }

        public SingleClubMember()
        {
           
        }
        public SingleClubMember( string name, Club club) : base( name)
        {
            ID = 1000 + Members.Count;
            Name = name;
            Club = club;
        }

        public override void CheckIn(Member member, string input)
        {

            SingleClubMember singleClubMember = new SingleClubMember();
            singleClubMember = (SingleClubMember)member;

            if (input == singleClubMember.Club.Name) 
            {
                Console.WriteLine($"Thank you for checking into the {singleClubMember.Club.Name}");
            }
            else
            {
                Console.WriteLine("ERROR! Club not found under membership.");
            }
        }

        public override double CalculateFee()

        {
            return Club.Fee;
        }
    }
}
