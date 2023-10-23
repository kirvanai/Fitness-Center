
namespace Fitness_Center.Models
{
    public class SingleClubMember : Member
    {
        public string ClubName {  get; set; }

        public SingleClubMember()
        {
           
        }
        public SingleClubMember( string name, string clubName) : base( name)
        {
            ID = 1000 + Members.Count;
            Name = name;
            ClubName = clubName;
        }

        public override void CheckIn(Member member, string input)
        {

            SingleClubMember singleClubMember = new SingleClubMember();
            singleClubMember = (SingleClubMember)member;

            if (input == singleClubMember.ClubName) 
            {
                Console.WriteLine($"Thank you for checking into the {ClubName}");
            }
            else
            {
                Console.WriteLine("ERROR! Club not found under membership.");
            }
        }

        public override double CalculateFee()
        {
            Club? club = new Club();

            club = Club.Clubs.FirstOrDefault(x => x.Name == ClubName);

            return club.Fee;
        }
    }
}
